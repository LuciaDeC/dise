using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class TareaMantenimiento
    {
        private int IdTarea;
        private Tanque Tanque;
        private DateTime Fecha;

        public TareaMantenimiento(int id, Tanque unTanque)
        {
            this.IdTarea = id;
            this.Tanque = unTanque;
            this.Fecha = DateTime.Now;
        }

        public int idTarea
        {
            get { return IdTarea; }
            set { IdTarea = value; }
        }

        public DateTime fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }

        public Tanque tanque
        {
            get { return Tanque; }
            set { Tanque = value; }
        }


    }
}
