using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Tanque : IObservable<Tanque>
    {
        private int IdTanque;
        private int Capacidad;
        private int CantidadActual;
        private double CapDisponiblePorcentaje;
        private String Descripcion;
        private int CapacidadDisponible;
        private int IndiceCalidad;

        //
        private List<IObserver<Tanque>> listaObeservers = new List<IObserver<Tanque>>();

        public Tanque(int numero, String descripcion, int capacidad)
        {
            this.idTanque = numero;
            this.descripcion = descripcion;
            this.capacidad = capacidad;
            this.cantidadActual = 0;
            this.CapacidadDisponible = capacidad;
            this.CapDisponiblePorcentaje = 100;
            this.IndiceCalidad = 5;
        }

        public IDisposable Subscribe(IObserver<Tanque> observer)
        {
            if (!this.listaObeservers.Contains(observer))
            {
                listaObeservers.Add(observer);
            }
            return new Unsubscriber(this.listaObeservers, observer);
        }

        private void Notify(Tanque tanque)
        {
            foreach (var observer in this.listaObeservers)
            {
                if (this.cantidadActual == 0)
                {
                    observer.OnError(new Exception("Error en observer!"));
                }
                else
                {
                    observer.OnNext(this);
                }
            }
        }

        class Unsubscriber : IDisposable
        {
            private List<IObserver<Tanque>> _observers;
            private IObserver<Tanque> _observer;

            public Unsubscriber(List<IObserver<Tanque>> listaObeservers,
                IObserver<Tanque> observer)
            {
                this._observers = listaObeservers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (this._observer != null
                    && this._observers.Contains(this._observer))
                {
                    this._observers.Remove(_observer);
                }
            }
        }

        public String descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }


        public int cantidadActual
        {
            get { return CantidadActual; }
            set
            {
                CantidadActual = value;
                this.Notify(this);
            }
        }


        public int capacidad
        {
            get { return Capacidad; }
            set { Capacidad = value; }
        }

        public int indiceCalidad
        {
            get { return IndiceCalidad; }
            set { IndiceCalidad = value; }
        }

        public int idTanque
        {
            get { return IdTanque; }
            set { IdTanque = value; }
        }

        public int capacidadDisponible
        {
            get { return CapacidadDisponible; }
            set { CapacidadDisponible = value; }
        }

        public double capacidadDispoPorcentaje
        {
            get { return CapDisponiblePorcentaje; }
            set { CapDisponiblePorcentaje = value; }
        }
    }
}