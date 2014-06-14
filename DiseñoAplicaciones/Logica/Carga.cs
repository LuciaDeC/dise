using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Carga
    {
        private int Numero;
        private Manguera Manguera;
        private int Cantidad;
        private Vehiculo Vehiculo;
        private Surtidor Surtidor;
        private Cliente Cliente;
        private Usuario Usuario;
        private DateTime Fecha;

        public Carga(int unNumero, Manguera unaManguera, int unaCantidad, Vehiculo unVehiculo, Surtidor unSurtidor, Cliente unCliente, Usuario unUsuario)
        {
                
            this.numero = unNumero;
                this.manguera = unaManguera;
                this.cantidad = unaCantidad;
                this.vehiculo = unVehiculo;
                this.surtidor = unSurtidor;
                this.cliente = unCliente;
                this.usuario = unUsuario;
                this.Fecha = DateTime.Now.Date;
                unaManguera.tanque.cantidadActual = unaManguera.tanque.cantidadActual - unaCantidad;
                unaManguera.litrosExpendidos = unaManguera.litrosExpendidos + unaCantidad;
                unaManguera.tanque.capacidadDisponible = unaManguera.tanque.capacidad - unaManguera.tanque.cantidadActual;
                unaManguera.tanque.capacidadDispoPorcentaje = (unaManguera.tanque.capacidadDisponible * 100) / unaManguera.tanque.capacidad;
         }

        public Vehiculo vehiculo
        {
            get { return Vehiculo; }
            set { Vehiculo = value; }
        }

        public Surtidor surtidor
        {
            get { return Surtidor; }
            set { Surtidor = value; }
        }

        public Cliente cliente
        {
            get { return Cliente; }
            set { Cliente = value; }
        }

        public Usuario usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public int cantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }


        public Manguera manguera
        {
            get { return Manguera; }
            set { Manguera = value; }
        }

        public int numero
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public DateTime fecha
        {
            get { return Fecha; }
            set { fecha = DateTime.Now; }
        }
        
        public override string ToString()
        {
            return numero + " - " + cantidad + "Lts - Cliente: " + cliente.ci + " - Fecha carga: " + fecha.ToString("dd-MM-yyyy");
        }
    }
}
