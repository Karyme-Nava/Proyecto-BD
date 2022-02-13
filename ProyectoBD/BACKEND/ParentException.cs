using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.BACKEND
{
    public class ParentException : Exception
    {
        public ParentException() : base("Ha ocurrido un error ya que está intentado eliminar información que contiene relación con otra existente. ")
        { }
        public ParentException(string message) : base("Ha ocurrido un error ya que está intentado eliminar información que contiene relación con otra existente. " + message)
        { }
    }
}
