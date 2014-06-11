using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Vehiculo
    {

        private String Matricula;
        private String Modelo;
        private String Marca;
        private Cliente Cliente;

        public Vehiculo(String unaMatricula, String unModelo, String unaMarca, Cliente cliente)
        {
            this.matricula = unaMatricula;
            this.modelo = unModelo;
            this.marca = unaMarca;
            this.Cliente = cliente;
        }

        public String marca
        {
            get { return Marca; }
            set { Marca = value; }
        }


        public String modelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }


        public String matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        public Cliente cliente
        {
            get { return Cliente; }
            set { Cliente = value; }
        }

        public override string ToString()
        {
            return "Matricula: " + matricula + " - Modelo: " + marca + " " + modelo + " - Cedula cliente: " + cliente.ci;
        }
    }
}
