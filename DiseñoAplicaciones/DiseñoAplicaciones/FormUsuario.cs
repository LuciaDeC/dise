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
    public partial class FormUsuario : Form
    {
        private FachadaUISistema fachada;
        private Usuario usuarioSleccionado;

        public FormUsuario()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            usuarioSleccionado = null;

            listaUsuarios.Items.Clear();
            foreach (Usuario u in fachada.getListaUsuarios())
            {
                listaUsuarios.Items.Add(u);
            }
            listaUsuarios.Show();
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
                    if (usuarioSleccionado == null)
                    {
                        fachada.crearUsuario(cedula, nombre, apellido);
                        MessageBox.Show("El usuario ha sido creado");
                        borrarDatos();
                    }
                    else {
                        fachada.editarUsuario(cedula, nombre, apellido, usuarioSleccionado);
                        MessageBox.Show("El usuario ha sido editado");
                        borrarDatos();    
                    }
                    
                    listaUsuarios.Items.Clear();
                    foreach (Usuario u in fachada.getListaUsuarios())
                    {
                        listaUsuarios.Items.Add(u);     
                    }
                    listaUsuarios.Show();
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
            usuarioSleccionado = null;
            listaUsuarios.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FromUsuario_Load(object sender, EventArgs e)
        {

        }

        private void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaUsuarios.SelectedItem != null)
            {
                usuarioSleccionado = (Usuario)listaUsuarios.SelectedItem;
                txtCedula.Text = (usuarioSleccionado).ci;
                txtApellido.Text = (usuarioSleccionado).apellido;
                txtNombre.Text = (usuarioSleccionado).nombre;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioSleccionado != null)
            {
                fachada.eliminarUsuario(usuarioSleccionado);
                MessageBox.Show("El usuario ha sido eliminado");
                borrarDatos();
                listaUsuarios.Items.Clear();
                foreach (Usuario u in fachada.getListaUsuarios())
                {
                    listaUsuarios.Items.Add(u);
                }
                listaUsuarios.Show();
                usuarioSleccionado = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
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
