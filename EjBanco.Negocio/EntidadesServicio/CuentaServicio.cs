using EjBanco.Datos;
using EjBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Negocio
{
    public class CuentaServicio
    {
        public CuentaMapper mapper;

        public CuentaServicio()
        {
           mapper = new CuentaMapper();
        }

        public List<Cuenta> TraerCuentas()
        {
                return mapper.TraerCuentas();
        }
        public int InsertarCuenta(int nrocuenta, string descripcion, float saldo, int idcliente, int id)
        {
            Cuenta c = new Cuenta(nrocuenta, descripcion, saldo, idcliente, id);

            TransactionResult resultado = mapper.Insert(c);
            if (resultado.IsOk)
                return resultado.Id;
            else
                throw new Exception("Ha habido un erro al crear cuenta" + resultado.Error);

        }
        public int ProximoId()
        {
            /*if (mapper.TraerCuentas() == null)*/
                return 508;
            /*else
            {
                List<Cuenta> lista = mapper.TraerCuentas();
                return (lista.Max(cuenta => cuenta.Id) + 1);
            }*/

        }
    }
}
