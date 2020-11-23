using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Entidades
{
    public class PrestamoTipo
    {
        private double _tna;
        private string _linea;
        private int _id;

        public double TNA
        {
            get { return this._tna; }
        }
        public string Linea
        {
            get { return this._linea; }
        }
        public double Id
        {
            get { return this._id; }
        }

        PrestamoTipo() { }
        PrestamoTipo(double tna, string linea, int id)
        {
            _tna = tna;
            _linea = linea;
            _id = id;
        }
        public override string ToString()
        {
            return string.Format("tna {0},linea {1}, id {2}", this._tna, this._id, this._linea);
        }
        
    }
}
