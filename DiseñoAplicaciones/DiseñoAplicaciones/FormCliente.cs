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
    public partial class FormCliente : Form
    {
        private FachadaUISistema fachada;
        private Cliente clienteSeleccionado;
        
        public FormCliente()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            clienteSeleccionado = null;
            
            listaClientes.Items.Clear();
            foreach (Cliente c in fachada.getListaClientes())
            {
                listaClientes.Items.Add(c);
            }
            listaClientes.Show();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtNombre.Text.Trim();
                String apellido = txtApellido.Text.Trim();
                String cedula = txtCedula.Text.Trim();
                if ((nombre.Length > 0) && (apellido.Length > 0) && (cedula.Length > 0))
                {
                    if (clienteSeleccionado == null)
                    {
                        fachada.crearCliente(cedula, nombre, apellido);
                        MessageBox.Show("El cliente ha sido creado");
                        borrarDatos();
                    }
                    else {
                        fachada.editarCliente(cedula, nombre, apellido, clienteSeleccionado);
                        MessageBox.Show("El cliente ha sido editado");
                        borrarDatos();
                    }

                   
                   listaClientes.Items.Clear();
                    foreach (Cliente c in fachada.getListaClientes())
                    {
                        listaClientes.Items.Add(c);
                    }
                    
                    listaClientes.Show();
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clienteSeleccionado = null;
            listaClientes.SelectedItem = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                if(fachada.tieneVehiculos(clienteSeleccionado))
                {
                    MessageBox.Show("No se puede eliminar el cliente, este tiene vehiculos asignados");
                }else
                {
                    fachada.eliminarCliente(clienteSeleccionado);
                    MessageBox.Show("El cliente ha sido eliminado");
                    borrarDatos();
                    listaClientes.Items.Clear();
                    foreach (Cliente c in fachada.getListaClientes())
                    {
                        listaClientes.Items.Add(c);
                    }
                    listaClientes.Show();
                }
                clienteSeleccionado = null;
            }else{
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaClientes.SelectedItem != null)
            {
                clienteSeleccionado = (Cliente)listaClientes.SelectedItem;
       
                txtCedula.Text = (clienteSeleccionado).ci;
                txtApellido.Text = (clienteSeleccionado).apellido;
                txtNombre.Text = (clienteSeleccionado).nombre;
            }
        }

        private void borrarDatos()
        {
            txtCedula.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
        }
    }
}
