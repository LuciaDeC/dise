using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class TareaTratamientoAgua: TareaTratamiento
    {
       public TareaTratamientoAgua(int id, TanqueAgua unTanque) :
            base(id, unTanque)
        {
           
        }

        public override string ToString()
        {
            return base.idTarea + " - Fecha: " + base.fecha.ToString("dd-MM-yyyy") + " Nro. Tanque: " + base.tanque.idTanque.ToString();
        }
    }
}
