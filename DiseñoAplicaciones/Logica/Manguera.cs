using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Manguera
    {
        private int NumeroManguera;
        private TanqueCombustible Tanque;
        private int LitrosExpendidos;

        public Manguera(int unNumero, TanqueCombustible unTanque)
        {
            this.numeroManguera = unNumero;
            this.tanque = unTanque;
            this.litrosExpendidos = 0;
        }

        public int numeroManguera
        {
            get { return NumeroManguera; }
            set { NumeroManguera = value; }
        }

        public TanqueCombustible tanque
        {
            get { return Tanque; }
            set { Tanque = value; }
        }

        public int litrosExpendidos
        {
            get { return LitrosExpendidos; }
            set { LitrosExpendidos = value; }
        }

        public override string ToString()
        {
            return "Manguera: " + numeroManguera + " - Tanque: " + tanque.ToString();
        }

    }
}
