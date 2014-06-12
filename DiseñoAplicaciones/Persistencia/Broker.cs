using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Persistencia
{
    abstract public class Broker
    {
        protected ConnBD conn;

        public static Broker crearBroker(ObjetoPersistente o)
        {
            Broker br = null;
            if (o.GetType().Name == "Usuario")
            {
                br = new BrokerUsuario();
                return br;
            }
            else if (o.GetType().Name == "Cliente")
            {
                br = new BrokerCliente();
                return br;
            }
            else if (o.GetType().Name == "Vehiculo")
            {
                br = new BrokerVehiculo();
                return br;
            }
            else if (o.GetType().Name == "Carga")
            {
                br = new BrokerCarga();
                return br;
            }
            else if (o.GetType().Name == "Manguera")
            {
                br = new BrokerManguera();
                return br;
            }
            else if (o.GetType().Name == "Surtidor")
            {
                br = new BrokerSurtidor();
                return br;
            }
            else if (o.GetType().Name == "TanqueCombustible")
            {
                br = new BrokerTanqueCombustible();
                return br;
            }
            else if (o.GetType().Name == "TareaReposicion")
            {
                br = new BrokerTareaReposicion();
                return br;
            }
            else if (o.GetType().Name == "TipoCombustible")
            {
                br = new BrokerTipoCombustible();
                return br;
            }
            return br;
        }

        abstract public void agregar(ObjetoPersistente o);
        abstract public void modificar(ObjetoPersistente o);
        abstract public void eliminar(ObjetoPersistente o);
        abstract public ObjetoPersistente traerDatos(ObjetoPersistente o);
        abstract public List<ObjetoPersistente> traerLista();
    }
}
