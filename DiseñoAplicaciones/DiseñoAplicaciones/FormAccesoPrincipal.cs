using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace InterfazGrafica
{
    public partial class FormAccesoPrincipal : Form
    {
        private FachadaUISistema fachada;
        public FormAccesoPrincipal()
        {

            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente ventanaCliente = new FormCliente();
            ventanaCliente.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario ventanaUsuario = new FormUsuario();
            ventanaUsuario.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehiculo ventanaVehiculo = new FormVehiculo();
            ventanaVehiculo.Show();
        }

        private void mangueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManguera ventanaManguera = new FormManguera();
            ventanaManguera.Show();
        }

        private void surtidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tanquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tiposDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoCombustible ventanaTipos = new FormTipoCombustible();
            ventanaTipos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrarCarga ventanaCarga = new FormRegistrarCarga();
            ventanaCarga.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVehiculo ventanaVehiculo = new FormVehiculo();
            ventanaVehiculo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCliente ventanaCliente = new FormCliente();
            ventanaCliente.Show();
        }

        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fachada.cargarDatos()){
                MessageBox.Show("Los datos de prueba han sido cargados");
            }
            else
            {
                MessageBox.Show("No se pueden volver a cargar los datos de prueba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void pantallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPantalla ventanaPantalla = new FormPantalla();
            ventanaPantalla.Show();
        }

        private void asignarManguerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignarMangueras asignarMangueras = new FormAsignarMangueras();
            asignarMangueras.Show();
        }

        private void surtidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSurtidor ventanaSurtidor = new FormSurtidor();
            ventanaSurtidor.Show();
        }

        private void listadoDeCargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoCargas ventanaListadoCargas = new FormListadoCargas();
            ventanaListadoCargas.Show();
        }

        private void tareasDeReposiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteSurtidor ventanaHistorico = new FormReporteSurtidor();
            ventanaHistorico.Show();
        }

        private void combustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTareaReposicionComb ventanaTarea = new FormTareaReposicionComb();
            ventanaTarea.Show();
        }

        private void aceiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTareaTratamientoAceite ventana = new FormTareaTratamientoAceite();
            ventana.Show();
        }

        private void combustibleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormTanqueCombustible ventanaTanque = new FormTanqueCombustible();
            ventanaTanque.Show();
        }

        private void aceiteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormTanqueAceite ventanaTanque = new FormTanqueAceite();
            ventanaTanque.Show();
        }

        private void aguaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormTanqueAgua ventanaTanque = new FormTanqueAgua();
            ventanaTanque.Show();
        }


        private void aguaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormTareaTratamientoAgua ventanaTarea = new FormTareaTratamientoAgua();
            ventanaTarea.Show();
        }
    } 
}
