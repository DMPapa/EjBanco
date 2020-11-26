using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Entidades
{
    public class Operador
    {
        private Prestamo _prestamo;
        private double _comision;
        private double _porcentajeComision;

        public Prestamo Prestamo
        {
            get { return this._prestamo; }
            set { this._prestamo = value; }
        }
        public double Comision
        {
            get { return this._comision; }
        }
        public double Porcentaje
        {
            get { return this._porcentajeComision; }
        }
        public Operador(Prestamo prestamo)
        {
            _prestamo = prestamo;
            _comision = _prestamo.Monto * _porcentajeComision;
            _porcentajeComision = 0.15;
        }
        public override string ToString()
        {
            return ("ID: " + _prestamo.Id + " - Linea: " + Prestamo.Linea + " - Monto: " + Prestamo.Monto + "- Plazo: " + Prestamo.Plazo + " - TNA:" + Prestamo.TNA);
        }
    }
}
