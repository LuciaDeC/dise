using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class TipoCombustible
    {
        private String Nombre;

        public TipoCombustible(String unNombre)
        {
            this.nombre = unNombre;
        }

        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public override string ToString()
        {
            return "Tipo - " + nombre;
        }

    }
}
