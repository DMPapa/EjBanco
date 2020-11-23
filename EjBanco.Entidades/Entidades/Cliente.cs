using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Entidades
{
    public class Cliente
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private int _telefono;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private string _usuario;
        private string _host;
        private int _id;

        public int Dni
        { 
            get { return this._dni; }
            set { this._dni = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public string Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public int Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return this._fechaNacimiento; }
            set { this._fechaNacimiento = value; }
        }
        public DateTime FechaAlta
        {
            get { return this._fechaAlta; }
        }
        public bool Activo
        {
            get { return this._activo; }
            set { this._activo = value; }
        }
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Usuario
        { get { return this._usuario; } }
        public Cliente() { }
        public Cliente(int dni, string nombre, string apellido, string email, int telefono, DateTime fechanacimiento, int id )
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _telefono = telefono;
            _fechaNacimiento = fechanacimiento;
            _fechaAlta = DateTime.Today;
            _activo = true;
            _id = id;
            _usuario = "870931";
        }
    }
}
