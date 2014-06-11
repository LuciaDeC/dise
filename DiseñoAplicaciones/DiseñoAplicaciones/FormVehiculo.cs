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
    public partial class FormVehiculo : Form
    {
        private Vehiculo vehiculoSeleccionado;
        private FachadaUISistema fachada;

        public FormVehiculo()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            vehiculoSeleccionado = null;

            comboCliente.Items.Clear();
            foreach (Cliente c in fachada.getListaClientes())
            {
                comboCliente.Items.Add(c);
            }
            comboCliente.Show();

            listaVehiculos.Items.Clear();
            foreach (Vehiculo v in fachada.getListaVehiculos()) {
                listaVehiculos.Items.Add(v);
            }
            listaVehiculos.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String matricula = textBoxMatricula.Text.Trim();
                String marca = textBoxMarca.Text.Trim();
                String modelo = textBoxModelo.Text.Trim();
                Cliente cliente = (Cliente)comboCliente.SelectedItem;

                if ((matricula.Length > 0) && (marca.Length > 0) && (modelo.Length > 0) && (cliente != null))
                {
                    if (vehiculoSeleccionado == null)
                    {
                        fachada.crearVehiculo(matricula, modelo, marca, cliente);
                        MessageBox.Show("El vehículo ha sido creado");
                        borrarDatos();
                    }
                    else
                    {
                        fachada.editarVehiculo(vehiculoSeleccionado, (Cliente)comboCliente.SelectedItem, textBoxMarca.Text, textBoxModelo.Text, textBoxMatricula.Text);
                        MessageBox.Show("Se ha editado el elemento seleccionado de forma correcta!");
                    }
                    listaVehiculos.Items.Clear();
                    foreach (Vehiculo v in fachada.getListaVehiculos())
                    {
                        listaVehiculos.Items.Add(v);
                    }
                    listaVehiculos.Show();
                }
                else
                {
                    MessageBox.Show("Valores incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MiExcepcion es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            vehiculoSeleccionado = null;
            listaVehiculos.SelectedItem = null;
        }

        private void borrarDatos()
        {
            textBoxMarca.Clear();
            textBoxMatricula.Clear();
            textBoxModelo.Clear();
        }

        private void listaVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaVehiculos.SelectedItem != null)
            {
                vehiculoSeleccionado = (Vehiculo)listaVehiculos.SelectedItem;
                comboCliente.SelectedItem = vehiculoSeleccionado.cliente;
                textBoxMarca.Text = (vehiculoSeleccionado).marca.ToString();
                textBoxModelo.Text = (vehiculoSeleccionado).modelo.ToString();
                textBoxMatricula.Text = (vehiculoSeleccionado).matricula.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                fachada.eliminarVehiculo(vehiculoSeleccionado);
                MessageBox.Show("El vehiculo ha sido eliminado");
                borrarDatos();
                listaVehiculos.Items.Clear();
                foreach (Vehiculo v in fachada.getListaVehiculos())
                {
                    listaVehiculos.Items.Add(v);
                }
                comboCliente.SelectedItem = null;
                listaVehiculos.Show();
                vehiculoSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Vehiculo");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
