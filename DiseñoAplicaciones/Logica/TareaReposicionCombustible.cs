using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TareaReposicionCombustible : TareaReposicion
    {
        private int CantidadRepuesta;


        public TareaReposicionCombustible(int id, TanqueCombustible unTanque, int cantidad) :
            base(id, unTanque)
        {
            this.cantidadRepuesta = cantidad;
            unTanque.cantidadActual = unTanque.cantidadActual + cantidad;
            unTanque.capacidadDisponible = unTanque.capacidad - unTanque.cantidadActual;
        }

        public int cantidadRepuesta
        {
            get { return CantidadRepuesta; }
            set { CantidadRepuesta = value; }
        }



        public override string ToString()
        {
            return base.idTarea + " - Fecha: " + base.fecha.ToString("dd-MM-yyyy") + " - Cant.: " + cantidadRepuesta + " lts - Nro. Tanque: " + base.tanque.idTanque.ToString();
        }
    }
}
