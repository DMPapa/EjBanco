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
    public class TarjetaCreditoMapper
    {
        private List<TarjetaCredito> MapList (string json)
        {
            List<TarjetaCredito> n = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);
            return n;
        }
        private TransactionResult MapResultado (string json)
        {
            TransactionResult n = JsonConvert.DeserializeObject<TransactionResult>(json);
            return n;
        }
        private NameValueCollection ReverseMap (TarjetaCredito tarjetacredito)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("tipo", tarjetacredito.Tipo.ToString());
            n.Add("periodoVencimiento", tarjetacredito.PeriodoVencimiento.ToString());
            n.Add("limiteCompra", tarjetacredito.LimiteCompra.ToString());
            n.Add("nroPlastico", tarjetacredito.NroPlastico.ToString());
            n.Add("usuario", ConfigurationManager.AppSettings["870931"]);
            n.Add("idCliente", tarjetacredito.IdCliente.ToString());
                return n;
        }
        public TransactionResult Insert (TarjetaCredito tarjetacredito)
        {
            NameValueCollection obj = ReverseMap(tarjetacredito);
            string resultado = WebHelper.Post("/api/v1/tarjetacredito", obj);
            TransactionResult resultadotransaccion = MapResultado(resultado);
            return resultadotransaccion;
        }
        public List<TarjetaCredito> TraerTarjetas()
        {
            string json2 = WebHelper.Get("/api/v1/tarjetacredito" + ConfigurationManager.AppSettings["870931"]);
            List<TarjetaCredito> resultado = MapList(json2);
            return resultado;
        }
    }
}
