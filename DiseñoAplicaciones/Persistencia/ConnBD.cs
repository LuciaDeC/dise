using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class ConnBD
    {
        private static ConnBD instance;
        private SqlConnection conn;
        private SqlDataReader dr;

        public SqlDataReader getDataReader()
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
            this.conn = new SqlConnection("server=bruno-PC\\SQLEXPRESS;" +
                                          "Trusted_Connection=yes;" +
                                          "database=diseno; " +
                                          "connection timeout=30");
            try
            {
                conn.Open();
                /*ejemplo de como ejecutar sentencias y sacar los datos del resultado
                SqlCommand addSite = new SqlCommand("INSERT INTO Usuario (id) " + " VALUES (1)", conn);
                addSite.ExecuteNonQuery();

                string strSQL = string.Format("Select * From Usuario");
                SqlCommand myCommand = new SqlCommand(strSQL, conn);
                SqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["id"].ToString());
                }

                */
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.Write("Error al ejecutar la consulta " + ex);
            }
        }

        public void desconectarse()
        {
            this.conn.Close();
        }

        public void ejecutar(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia, this.conn);
            cmd.ExecuteNonQuery();
        }

        public void traerDatos(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia, this.conn);
            cmd.ExecuteNonQuery();
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
