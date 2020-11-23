using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Entidades
{
    public class TarjetaCredito
    {
        private int _tipo;
        private int _periodoVencimiento;
        private double _limiteCompra;
        private int _nroPlastico;
        private string _usuario;
        private int _idCliente;

        public int Tipo
        {
            get { return this._tipo; }
            set { this.Tipo = value; }
        }
        public int PeriodoVencimiento
        {
            get { return this._periodoVencimiento; }
            set { this._periodoVencimiento = value; }
        }
        public double LimiteCompra
        {
            get { return this._limiteCompra; }
            set { this._limiteCompra = value; }
        }
        public int NroPlastico
        {
            get { return this.NroPlastico; }
            set { this._nroPlastico = value; }
        }
        public int IdCliente
        {
            get { return this._idCliente; }
            set { this._idCliente = value; }
        }
        public string Usuario
        { get { return this._usuario; } }
        public TarjetaCredito() { }
        public TarjetaCredito(int tipo, int periodovencimiento, double limitecompra, int nroplastico, int idcliente)
        {
            _tipo = tipo;
            _periodoVencimiento = periodovencimiento;
            _limiteCompra = limitecompra;
            _nroPlastico = nroplastico;
            _idCliente = idcliente;
        }
    }
}
