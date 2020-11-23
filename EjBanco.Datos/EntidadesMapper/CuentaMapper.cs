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
    public class CuentaMapper
    {
        private TransactionResult MapResultado(string json)
        {
            TransactionResult n = JsonConvert.DeserializeObject<TransactionResult>(json);
            return n;
        }
        private List<Cuenta> MapList(string json)
        {
            List<Cuenta> n = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return n;
        }
        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("NroCuenta", cuenta.NroCuenta.ToString());
            n.Add("Descripcion", cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString());
            n.Add("FechaApertura", cuenta.FechaApertura.ToShortDateString());
            n.Add("FechaModificacion", cuenta.FechaModificacion.ToShortDateString());
            n.Add("Activo", cuenta.Activo.ToString());
            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("id", cuenta.Id.ToString());

            return n;
        }
        public List<Cuenta> TraerCuentas()
        {
            string json2 = WebHelper.Get("/api/v1/cuenta/" + ConfigurationManager.AppSettings["legajo"]);
            List<Cuenta> resultado = MapList(json2);
            return resultado;
        }


        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);
            string result = WebHelper.Post("/api/v1/cuenta/", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }

    }
}
