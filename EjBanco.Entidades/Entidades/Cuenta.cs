using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Entidades
{
    public class Cuenta
    {
        private int _nroCuenta;
        private string _descripcion;
        private float _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private int _id;

        public int NroCuenta
        {
            get { return this._nroCuenta; }
            set { this._nroCuenta = value; }
        }
        public string Descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }
        public float Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }
        public DateTime FechaApertura
        {
            get { return this._fechaApertura; }
        }
        public DateTime FechaModificacion
        {
            get { return this._fechaModificacion; }
            set { this._fechaModificacion = value; }
        }
        public bool Activo
        {
            get { return this._activo; }
            set { this._activo = value; }
        }
        public int IdCliente
        {
            get { return this._idCliente; }
            set { this._id = value; }
        }
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        
        public Cuenta() { }
        public Cuenta(int nrocuenta, string descripcion, float saldo, int idcliente, int id) 
        {
            _nroCuenta = nrocuenta;
            _descripcion = descripcion;
            _saldo = saldo;
            _fechaApertura = DateTime.Today;
            _fechaModificacion = DateTime.Today;
            _activo = true;
            _idCliente = idcliente;
            _id = id;
        }

    }



}
