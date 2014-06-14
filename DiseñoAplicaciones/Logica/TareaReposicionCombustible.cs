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
            this.tanque.cantidadActual = unTanque.cantidadActual + cantidad;
            this.tanque.capacidadDisponible = unTanque.capacidad + unTanque.cantidadActual;
            this.tanque.capacidadDispoPorcentaje = (unTanque.capacidadDisponible * 100) / unTanque.capacidad;

        }
        
        public override string ToString()
        {
            return base.idTarea + " - Fecha: " + base.fecha.ToString("dd-MM-yyyy") + " - Cant.: " + cantidadRepuesta + " lts - Nro. Tanque: " + base.tanque.idTanque.ToString();
        }
    }
}
