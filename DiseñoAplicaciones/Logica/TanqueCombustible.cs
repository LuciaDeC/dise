﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class TanqueCombustible : Tanque
    {
        private TipoCombustible TipoCombubstible;

        public TanqueCombustible(int numero, String descripcion, int capacidad, TipoCombustible tipo)
            : base(numero, descripcion, capacidad)
        {
            this.tipoCombustible = tipo;
            this.capacidadDispoPorcentaje = base.capacidadDispoPorcentaje;
            this.capacidadDisponible = base.capacidadDisponible;
            this.cantidadActual = base.cantidadActual;
        }

        public TipoCombustible tipoCombustible
        {
            get { return TipoCombubstible; }
            set { TipoCombubstible = value; }
        }
        public override string ToString()
        {
            return base.idTanque + " - " + base.descripcion + " - " + tipoCombustible.nombre + " - Capacidad: " + base.capacidad + "Lts - Disponible: " + base.cantidadActual;
        }
    }
}