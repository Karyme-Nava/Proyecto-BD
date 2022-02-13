using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.BACKEND
{
    public class ConexionException : Exception 
    {
        public ConexionException() : base("Ha ocurrido un error al conectar con la BD. Intente más tarde o avise al encargado del sistema si sigue presentando problemas.")
        {

        }
    }
}
