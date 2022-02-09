using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.POJOS
{
    class clsCategorias
    {
        private int idCategoria;
        private string nombreCategoria;
        private string descripcion;

        public int IDCategoria
        {
            get
            {
                return idCategoria;
            }
            set
            {
                idCategoria = value;
            }
        }

        public string NombreCategoria
        {
            get
            {
                return nombreCategoria;
            }
            set
            {
                nombreCategoria = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
    }
}
