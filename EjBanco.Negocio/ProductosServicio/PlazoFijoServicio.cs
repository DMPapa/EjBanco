using EjBanco.Datos;
using EjBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Negocio
{
    public class PlazoFijoServicio
    {
        private PlazoFijoMapper mapper;

        PlazoFijoServicio()
        {
            PlazoFijoMapper mapper = new PlazoFijoMapper();
        }
        public List<PlazoFijo> TraerPlazosFijos()
        {
            return mapper.TraerPlazosFijos();
        }
        public int InsertarPF(int idcliente, int id, int tipo, int dias, double capitalinicial, double tasa, double interes)
        {
            PlazoFijo PF = new PlazoFijo(idcliente, id, tipo, dias, capitalinicial, tasa, interes);

            TransactionResult resultado = mapper.Insert(PF);
            if (resultado.IsOk)
                return resultado.Id;
            else
                throw new Exception("Ha habido un erro al crear Plazo fijo" + resultado.Error);
            
        }
    }
}
