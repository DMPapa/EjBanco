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
    public class PrestamoMapper
    {

        private TransactionResult MapResultado (string json)
        {
            TransactionResult n = JsonConvert.DeserializeObject<TransactionResult>(json);
            return n;
        }
        private List<Prestamo> MapList (string json)
        {
            List<Prestamo> n = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return n;
        }
        private NameValueCollection ReverseMap (Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", prestamo.Id.ToString());
            n.Add("tna", prestamo.TNA.ToString());
            n.Add("linea", prestamo.Linea);
            n.Add("plazo", prestamo.Plazo.ToString());
            n.Add("idCliente", prestamo.IdCliente.ToString());
            n.Add("idTipo", prestamo.IdTipo.ToString());
            n.Add("monto", prestamo.Monto.ToString());
            n.Add("cuota", prestamo.Cuota.ToString());
            n.Add("usuario", ConfigurationManager.AppSettings["870931"]);
            n.Add("tipoPrest", prestamo.PrestamoTipo.ToString());
                return n;
        }
        public TransactionResult Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);
            string resultado = WebHelper.Post("/api/v1/prestamo", obj);
            TransactionResult resultadotransaccion = MapResultado(resultado);
            return resultadotransaccion;
        }
        public List<Prestamo> TraerPrestamos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamo" + ConfigurationManager.AppSettings["870931"]);
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }



    }
}
