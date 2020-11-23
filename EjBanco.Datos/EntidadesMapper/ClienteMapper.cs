using Newtonsoft.Json;
using EjBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Datos
{
    public class ClienteMapper
    {
        private List<Cliente> MapList(string json)
        {
            return JsonConvert.DeserializeObject<List<Cliente>>(json);
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult n = JsonConvert.DeserializeObject<TransactionResult>(json);
            return n;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("usuario", ConfigurationManager.AppSettings["legajo"]);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToShortDateString());
            n.Add("Activo", cliente.Activo.ToString());

            return n;
        }
        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/api/v1/cliente/", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }
        public List<Cliente> TraerClientes()
        {
            string json2 = WebHelper.Get("/api/v1/cliente/" + ConfigurationManager.AppSettings["legajo"]);
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }




    }

}
