using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logica;

namespace Persistencia
{
    public class FPersistencia : IPersistencia
    {
        private ConnBD m_conexion;

        public FPersistencia()
        {
            this.Conexion = ConnBD.getInstance();
        }

        public ConnBD Conexion
        {
            get { return m_conexion; }
            set { m_conexion = value; }
        }
        public void agregar(ObjetoPersistente o)
        {
            Broker br = Broker.crearBroker(o);
            br.agregar(o);
        }
        public void modificar(ObjetoPersistente o)
        {
            Broker br = Broker.crearBroker(o);
            br.modificar(o);
        }
        public void eliminar(ObjetoPersistente o)
        {
            Broker br = Broker.crearBroker(o);
            br.eliminar(o);
        }
        public void traerDatos(ObjetoPersistente o)
        {

        }
        public void conectarse()
        {
            Conexion.conectarse();
        }
        public void desconectarse()
        {
            Conexion.desconectarse();
        }
        public List<ObjetoPersistente> traerLista(ObjetoPersistente o)
        {
            Broker br = Broker.crearBroker(o);
            return br.traerLista();
        }
    }
}
