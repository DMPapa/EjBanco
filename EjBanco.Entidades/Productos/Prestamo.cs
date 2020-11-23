using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Entidades
{
    public class Prestamo
    {
        private int _id;
        private double _tna;
        private string _linea;
        private int _plazo;
        private int _idCliente;
        private int _idTipo;
        private double _monto;
        private double _cuota;
        private PrestamoTipo _prestamoTipo;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public double TNA
        {
            get { return this._tna; }
            set { this._tna = value; }
        }
        public string Linea
        {
            get { return this._linea; }
            set { this._linea = value; }
        }
        public int Plazo
        {
            get { return this._plazo; }
            set { this._plazo = value; }
        }
        public int IdCliente
        {
            get { return this._idCliente; }
            set { this._idCliente = value; }
        }
        public int IdTipo
        {
            get { return this._idTipo; }
            set { this._idTipo = value; }
        }
        public double Monto
        {
            get { return this._monto; }
            set { this._monto = value; }
        }
        public double Cuota
        {
            get { return this._cuota; }
            set { this._cuota = value; }
        }
        public PrestamoTipo PrestamoTipo
        {
            get { return this._prestamoTipo; }
            set { this._prestamoTipo = value; }
        }
        public Prestamo() { }
        public Prestamo(int id, double tna, string linea, int plazo, int idcliente, int idtipo, double monto, double cuota, PrestamoTipo prestamotipo)
        {
            _id = id;
            _tna = tna;
            _linea = linea;
            _plazo = plazo;
            _idCliente = idcliente;
            _idTipo = idtipo;
            _monto = monto;
            _cuota = cuota;
            _prestamoTipo = prestamotipo;

        }
    }
}
