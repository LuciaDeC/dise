using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Persona
    {
        private String Nombre;
        private String Apellido;
        private String Ci;

        public Persona(String cedula, String nombre, String apellido)
        {
            this.ci = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public String apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public String ci
        {
            get { return Ci; }
            set { Ci = value; }
        }

        public int compareTo(Object obj)
        {

            Persona per = obj as Persona;
            if (per == null)
            {
                return 0;
            }
            return ci.CompareTo(per.ci);
        }
        public override string ToString()
        {
            return "Cedula - " + ci + " - " + nombre + " " + apellido;
        }
    }
}