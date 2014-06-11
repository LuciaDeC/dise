using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuario : Persona
    {

      

        public Usuario(String cedula, String nombre, String apellido)
            : base(cedula, nombre, apellido)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
