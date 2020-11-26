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
        private List<Operador> operadorLista;
        private Operador operador;

        public PrestamoServicio()
        {
             mapper = new PrestamoMapper();
        }

        public List <Operador> TraerPrestamosOperador()
        {
            operadorLista = new List<Operador>();
            foreach (Prestamo p in mapper.TraerPrestamos())
                operadorLista.Add(new Operador(p));
            return operadorLista;
        }
        public int InsertarPrestamo(Prestamo p)
        {
            TransactionResult resultado = mapper.Insert(p);
            if (resultado.IsOk)
                return resultado.Id;
            else
                throw new Exception("Ha habido un error al crear préstamo" + resultado.Error);
        }
        public double SimularCuotaCapital(Operador o)
        {
            return o.Prestamo.CalcularCuotaCapital();
        }
        public double SimularCuotaInteres(Operador o)
        {
            return o.Prestamo.CalcularCuotaInteres();
        }
        public int ProximoId()
        {
            List<Prestamo> lista = mapper.TraerPrestamos();
            return (lista.Max(cuenta => cuenta.Id) + 1);

        }
        
    }
}
