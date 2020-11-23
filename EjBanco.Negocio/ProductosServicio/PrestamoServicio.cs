using EjBanco.Datos;
using EjBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Negocio
{
    public class PrestamoServicio
    {
        private PrestamoMapper mapper;

        public PrestamoServicio()
        {
            PrestamoMapper mapper = new PrestamoMapper();
        }

        public List <Prestamo> TraerPrestamos()
        {
            return mapper.TraerPrestamos();
        }
        public int InsertarPrestamo(int id, double tna, string linea, int plazo, int idcliente, int idtipo, double monto, double cuota, PrestamoTipo prestamotipo)
        {
            Prestamo p = new Prestamo(id, tna, linea, plazo, idcliente, idtipo, monto, cuota, prestamotipo);

            TransactionResult resultado = mapper.Insert(p);
            if (resultado.IsOk)
                return resultado.Id;
            else
                throw new Exception("Ha habido un error al crear préstamo" + resultado.Error);
        }
    }
}
