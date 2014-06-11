using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente : Persona
    {
        private List<Vehiculo> ListaVehiculos;

        public Cliente(String cedula, String nombre, String apellido)
            : base(cedula, nombre, apellido)
        {
            this.listaVehiculo = new List<Vehiculo>();
        }

        public List<Vehiculo> listaVehiculo
        {
            get { return ListaVehiculos; }
            set { ListaVehiculos = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}