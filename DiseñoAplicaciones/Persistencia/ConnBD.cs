using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;

namespace Persistencia
{
    public class ConnBD
    {
        private static ConnBD instance;
        private OleDbConnection conexion;
        private OleDbDataReader dr;

        public OleDbDataReader getDataReader()
        {
            return this.dr;
        }

        static public ConnBD getInstance()
        {
            if (instance == null)
            {
                instance = new ConnBD();
            }
            return instance;
        }

        public void conectarse()
        {
          /*  this.conexion = new OleDbConnection(ConfigurationManager.AppSettings["Path"]);
            this.conexion.Close();
            this.conexion.Open();*/
        }

        public void desconectarse()
        {
            this.conexion.Close();
        }

        public void ejecutar(string sentencia)
        {
            OleDbCommand cmd = new OleDbCommand(sentencia, this.conexion);
            cmd.ExecuteNonQuery();
        }

        public void traerDatos(string sentencia)
        {
            OleDbCommand cmd = new OleDbCommand(sentencia, this.conexion);
            this.dr = cmd.ExecuteReader();
        }

        public object obtenerValor(string cadena)
        {
            return dr[cadena];
        }

        public object obtenerValor(int indice)
        {
            return dr[indice];
        }

        public bool hayRegistro()
        {
            bool hayRegistro = false;
            if (this.dr.Read())
            {
                hayRegistro = true;
            }
            else
            {
                this.dr.Close();
            }
            return hayRegistro;
        }
    }
}
