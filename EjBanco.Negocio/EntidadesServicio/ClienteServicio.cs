using EjBanco.Datos;
using EjBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }
        
        public List<Cliente> TraerClientes()
        {
            return mapper.TraerClientes();
        }

        public int InsertarCliente(int dni, string nombre, string apellido, string email, int telefono, DateTime fechanacimiento, bool activo, int id)
        {
            Cliente c = new Cliente(dni, nombre, apellido, email, telefono, fechanacimiento,id);

            TransactionResult transaccion = mapper.Insert(c);
            if (transaccion.IsOk)
                return transaccion.Id;
            else
                throw new Exception("ha habido un error al crear cliente" + transaccion.Error);
        }

    }
}
