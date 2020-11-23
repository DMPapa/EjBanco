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
    public class PrestamoTipoMapper
    {

        private List<PrestamoTipo> MapList(string json)
        {
            List<PrestamoTipo> n = JsonConvert.DeserializeObject<List<PrestamoTipo>>(json);
            return n;
        }

        public List<PrestamoTipo> TraerPrestamosTipos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamotipo/");
            List<PrestamoTipo> resultado = MapList(json2);
            return resultado;
        }
    }
}
