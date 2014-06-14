using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TanqueAgua: Tanque
    {
        private String localizacion;

        public TanqueAgua(int numero, String descripcion, int capacidad, String local)
            : base(numero, descripcion, capacidad)
        {
            this.localizacion = local;
            this.capacidadDispoPorcentaje = base.capacidadDispoPorcentaje;
            this.capacidadDisponible = base.capacidadDisponible;
            this.cantidadActual = base.cantidadActual;
            this.fechaUltimaLimpieza = base.fechaUltimaLimpieza;

                        
        }

        public String Localizacion
        {
            get { return localizacion; }
            set { localizacion = value; }
        }
        public override string ToString()
        {
            return base.idTanque + " - " + base.descripcion + " - Cap: " + base.capacidad + "Lts - Cant Actual: " + base.cantidadActual + "Lts - Localización: " + localizacion + " - Ind calidad: " + base.indiceCalidad;
        }

    }
}
