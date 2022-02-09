using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.POJOS
{
    class clsProblemas
    {
        private int idProblema;
        private string nombre;
        private string descripcion;
        private string solucion;
        private int idCategoria;
        private int puntaje;
        private string nivelDificultad;
        private string gestor;
        private string baseDatos;
        private string visibilidad;
        private DateTime fechaCreacion;
        private string fuente;

        public int IDProblema
        {
            get
            {
                return idProblema;
            }
            set
            {
                idProblema = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
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

        public string Solucion
        {
            get
            {
                return solucion;
            }
            set
            {
                solucion = value;
            }
        }

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

        public int Puntaje
        {
            get
            {
                return puntaje;
            }
            set
            {
                puntaje = value;
            }
        }

        public string NivelDificultad
        {
            get
            {
                return nivelDificultad;
            }
            set
            {
                nivelDificultad = value;
            }
        }

        public string Gestor
        {
            get
            {
                return gestor;
            }
            set
            {
                gestor = value;
            }
        }

        public string BaseDatos
        {
            get
            {
                return baseDatos;
            }
            set
            {
                baseDatos = value;
            }
        }

        public string Visibilidad
        {
            get
            {
                return visibilidad;
            }
            set
            {
                visibilidad = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }
            set
            {
                fechaCreacion = value;
            }
        }

        public string Fuente
        {
            get
            {
                return fuente;
            }
            set
            {
                fuente = value;
            }
        }
    }
}
