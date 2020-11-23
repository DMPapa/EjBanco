using EjBanco.Datos;
using EjBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Negocio
{
    public class TarjetaCreditoServicio
    {
        private TarjetaCreditoMapper mapper;

        public TarjetaCreditoServicio()
        {
            TarjetaCreditoMapper mapper = new TarjetaCreditoMapper();
        }
        public List<TarjetaCredito> TraerTarjetas()
        {
            return mapper.TraerTarjetas();
        }
        public int InsertarTC(int tipo, int periodovencimiento, double limitecompra, int nroplastico, int idcliente)
        {
            TarjetaCredito TC = new TarjetaCredito(tipo, periodovencimiento, limitecompra, nroplastico, idcliente);

            TransactionResult resultado = mapper.Insert(TC);

            if (resultado.IsOk)
                return resultado.Id;
            else
                throw new Exception("Ha habido un erro al crear la tarjeta" + resultado.Error);
        }
    }
}
