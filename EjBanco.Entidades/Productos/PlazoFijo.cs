using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Entidades
{
    public class PlazoFijo
    {
        private int _idCliente;
        private int _id;
        private int _tipo;
        private int _dias;
        private double _capitalInicial;
        private double _tasa;
        private double _interes;
        
        public int IdCliente
        {
            get { return this._idCliente; }
        }
        public int Id
        {
            get { return this._id; }
        }
        public int Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }
        public int Dias
        { 
            get { return this._dias; }
            set { this._dias = value; }
        }
        public double CapitaInicial
        {
            get { return this._capitalInicial; }
            set { this._capitalInicial = value; }
        }
        public double Tasa
        {
            get { return this._tasa; }
            set { this._tasa = value; }
        }
        public double Interes
        {
            get { return this._interes; }
            set { this._interes = value; }
        }
        public PlazoFijo() { }
        public PlazoFijo(int idcliente, int id, int tipo, int dias, double capitalinicial, double tasa, double interes)
        {
            _idCliente = idcliente;
            _id = id;
            _tipo = tipo;
            _dias = dias;
            _capitalInicial = capitalinicial;
            _tasa = tasa;
            _interes = interes;
        }
            
    }
}
