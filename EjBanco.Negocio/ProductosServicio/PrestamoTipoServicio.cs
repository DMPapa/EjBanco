using EjBanco.Datos;
using EjBanco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjBanco.Negocio
{
    public class PrestamoTipoServicio
    {
        private PrestamoTipoMapper mapper;

        public PrestamoTipoServicio()
        {
            mapper = new PrestamoTipoMapper();
        }

        public List<PrestamoTipo> TraerTiposDePrestamos()
        {
            return mapper.TraerPrestamosTipos();
        }
        

    }
}
