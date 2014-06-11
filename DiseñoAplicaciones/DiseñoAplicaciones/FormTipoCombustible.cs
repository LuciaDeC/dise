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
    public partial class FormTipoCombustible : Form
    {
        private FachadaUISistema fachada;

        private TipoCombustible tipoSeleccionado;

        public FormTipoCombustible()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();

            tipoSeleccionado = null;

            listaTiposCombustible.Items.Clear();
            foreach (TipoCombustible t2 in fachada.getListaTiposCombustible())
            {
                listaTiposCombustible.Items.Add(t2);
            }

            listaTiposCombustible.Show();
        }


        private void TipoCombustible_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
                String descripcion = textDescripcion.Text.Trim();
                if (descripcion.Length > 0)
                {
                    if (tipoSeleccionado == null)
                    {
                        fachada.crearTipoCombustible(descripcion);
                        MessageBox.Show("El tipo de combustible ha sido creado");
                    }
                    else
                    {
                        fachada.editarTipoCombustible((TipoCombustible)listaTiposCombustible.SelectedItem, textDescripcion.Text);
                        MessageBox.Show("Se ha editado el elemento seleccionado de forma correcta!");
                    }
                    listaTiposCombustible.Items.Clear();
                    foreach (TipoCombustible t in fachada.getListaTiposCombustible())
                    {
                        listaTiposCombustible.Items.Add(t);
                    }
                    listaTiposCombustible.Show();
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
            tipoSeleccionado = null;
            listaTiposCombustible.SelectedItem = null;
        }

        private void listaTiposCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaTiposCombustible.SelectedItem != null)
            {
                tipoSeleccionado = (TipoCombustible)listaTiposCombustible.SelectedItem;
                textDescripcion.Text = tipoSeleccionado.nombre;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tipoSeleccionado != null)
            {
                fachada.eliminarTipoCombustible(tipoSeleccionado.nombre);
                MessageBox.Show("Se ha eliminado el elemento seleccionado de forma correcta!");
                listaTiposCombustible.Items.Clear();
                foreach (TipoCombustible t2 in fachada.getListaTiposCombustible())
                {
                    listaTiposCombustible.Items.Add(t2);
                }

                listaTiposCombustible.Show();
                tipoSeleccionado = null;
                borrarDatos();

            }
               
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de combustible");
            }
        }

        private void borrarDatos() {
            textDescripcion.Clear();
        }

    }
}
