using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.BACKEND
{
    [Serializable]
    public class DuplicationException: Exception
    {
        public DuplicationException() : base("Ha ocurrido un error ya que está intentado ingresar información que ya se encuentra en la base de datos registrada, la cual no puede repetirse.")
        { }
        public DuplicationException(string message) : base("Ha ocurrido un error ya que está intentado ingresar información que ya se encuentra en la base de datos registrada, la cual no puede repetirse. " + message)
        { }
    }
}
