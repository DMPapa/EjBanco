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
    public class PlazoFijoMapper
    {
        private TransactionResult MapResultado(string json)
        {
            TransactionResult n = JsonConvert.DeserializeObject<TransactionResult>(json);
            return n;
        }
        private List<PlazoFijo> MapList(string json)
        {
            List<PlazoFijo> n = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
            return n;
        }

        private NameValueCollection ReverseMap(PlazoFijo plazofijo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", plazofijo.IdCliente.ToString());
            n.Add("id", plazofijo.Id.ToString());
            n.Add("tipo", plazofijo.Tipo.ToString());
            n.Add("dias", plazofijo.Dias.ToString());
            n.Add("capitalInicial", plazofijo.CapitaInicial.ToString());
            n.Add("tasa", plazofijo.Tasa.ToString());
            n.Add("interes", plazofijo.Interes.ToString());
            n.Add("usuario", ConfigurationManager.AppSettings["legajo"]);

            return n;
        }
        public TransactionResult Insert(PlazoFijo plazofijo)
        {
            NameValueCollection obj = ReverseMap(plazofijo);
            string result = WebHelper.Post("/api/v1/plazofijo/", obj);
            TransactionResult resultadotransaccion = MapResultado(result);
            return resultadotransaccion;
        }
        public List<PlazoFijo> TraerPlazosFijos()
        {
            string json2 = WebHelper.Get("api/v1/plazofijo/" + ConfigurationManager.AppSettings["legajo"]);
            List<PlazoFijo> resultado = MapList(json2);
            return resultado;
        }

    }

}
