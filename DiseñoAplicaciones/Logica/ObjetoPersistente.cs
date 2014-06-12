using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;
using System.Management;

namespace Logica
{
    public class ObjetoPersistente
    {
        private static IPersistencia m_ip;

        public ObjetoPersistente()
        {

        }

        public ObjetoPersistente(IPersistencia IPers)
        {
            ip = IPers;
        }

        public static IPersistencia ip
        {
            get { return m_ip; }
            set { m_ip = value; }
        }

        public void agregarse()
        {
            ip.agregar(this);

        }
        public void modificarse()
        {
            ip.modificar(this);

        }
        public void eliminarse()
        {
            ip.eliminar(this);
        }
        public void recuperarse()
        {
            ip.traerDatos(this);
        }
        public List<ObjetoPersistente> traerLista(ObjetoPersistente o)
        {
            return ip.traerLista(o);
        }
    }
}
