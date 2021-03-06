﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TanqueAceite: Tanque
    {
        private int viscosidad;
        
        //cim
        public TanqueAceite(int numero, String descripcion, int capacidad,  int viscosidad)
            : base(numero, descripcion, capacidad)
        {
            this.viscosidad =viscosidad;
            this.capacidadDispoPorcentaje = base.capacidadDispoPorcentaje;
            this.capacidadDisponible = base.capacidadDisponible;
            this.cantidadActual = base.cantidadActual;
            this.fechaUltimaLimpieza = base.fechaUltimaLimpieza;
                   
        }

        public int Viscosidad
        { 
            get { return viscosidad; }
            set { viscosidad = value; }
        }
        public override string ToString()
        {
            return base.idTanque + " - " + base.descripcion + " - Cap: " + base.capacidad + "Lts -  Cap Actual: " + base.cantidadActual + " - Viscosidad: " + viscosidad + " - Ind calidad: " + base.indiceCalidad;
        }
    }
}
