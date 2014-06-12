using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TareaReposicionCombustible : TareaReposicion
    {
       
        public TareaReposicionCombustible(int id, TanqueCombustible unTanque, int cantidad) :
            base(id, unTanque, cantidad)
        {
            
        }
        
        public override string ToString()
        {
            return base.idTarea + " - Fecha: " + base.fecha.ToString("dd-MM-yyyy") + " - Cant.: " + cantidadRepuesta + " lts - Nro. Tanque: " + base.tanque.idTanque.ToString();
        }
    }
}
