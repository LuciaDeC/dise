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
    public partial class FormTareaReposicionAgua : Form
    {
        private FachadaUISistema fachada;
        private TareaReposicionAgua tareaSeleccionada;

        public FormTareaReposicionAgua()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            tareaSeleccionada = null;

            comboBoxTanque.Items.Clear();
            foreach (TanqueAgua t in fachada.getListaTanquesAgua())
            {
                comboBoxTanque.Items.Add(t);
            }

            listBoxListaTareas.Show();
            listBoxListaTareas.Items.Clear();
            foreach (TareaReposicionAgua tarea in fachada.getListaTareasReposicionAgua())
            {
                listBoxListaTareas.Items.Add(tarea);
            }
            listBoxListaTareas.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                TanqueAgua tanque = (TanqueAgua)comboBoxTanque.SelectedItem;

                if ((textBoxCantidad.Text.Trim().Length > 0) && (tanque != null))
                {
                    int cantidad = Convert.ToInt32(textBoxCantidad.Text.Trim());
                    if (tareaSeleccionada == null)
                    {
                        fachada.crearTareaReposicionAgua((TanqueAgua)comboBoxTanque.SelectedItem, cantidad);
                        MessageBox.Show("La tarea ha sido creada");
                    }

                    listBoxListaTareas.Items.Clear();
                    foreach (TareaReposicionAgua t in fachada.getListaTareasReposicionAgua())
                    {
                        listBoxListaTareas.Items.Add(t);
                    }
                    listBoxListaTareas.Show();
                    borrarDatos();
                }
                else
                {
                    MessageBox.Show("Faltan datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void borrarDatos()
        {
            textBoxCantidad.Clear();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
