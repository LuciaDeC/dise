using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Surtidor
    {
        private int NumeroSerie;
        private List<Manguera> ListaMangueras;

        public Surtidor(int unNumero)
        {
            this.numeroSerie = unNumero;
            this.listaMangueras = new List<Manguera>();
        }

        public List<Manguera> listaMangueras
        {
            get { return ListaMangueras; }
            set { ListaMangueras = value; }
        }

        public int numeroSerie
        {
            get { return NumeroSerie; }
            set { NumeroSerie = value; }
        }
        public override string ToString()
        {
            return "Surtidor: " + numeroSerie.ToString() + " - " + this.listaMangueras.Count + " Mangueras";
        }
    }
}
