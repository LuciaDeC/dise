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
    public partial class FormTareaReposicionComb : Form
    {
        private FachadaUISistema fachada;
        private TareaReposicionCombustible tareaSeleccionada;

        public FormTareaReposicionComb()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            tareaSeleccionada = null;
           
            comboBoxTanque.Items.Clear();
            foreach (TanqueCombustible t in fachada.getListaTanquesCombustible())
            {
                comboBoxTanque.Items.Add(t);
            }

            listBoxListaTareas.Show();
            listBoxListaTareas.Items.Clear();
            foreach (TareaReposicionCombustible tarea in fachada.getListaTareasReposicionCombustible())
            {
                listBoxListaTareas.Items.Add(tarea);
            }
            listBoxListaTareas.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoCombustible tipoC = (TipoCombustible)comboBoxTipoComb.SelectedItem;
                TanqueCombustible tanque = (TanqueCombustible)comboBoxTanque.SelectedItem;

                if ((textBoxCantidad.Text.Trim().Length > 0) && (tipoC != null) && (tanque != null))
                {
                    int cantidad = Convert.ToInt32(textBoxCantidad.Text.Trim());

                    if (tareaSeleccionada == null)
                    {
                        fachada.crearTareaReposicionCombustible((TanqueCombustible)comboBoxTanque.SelectedItem, cantidad);
                        MessageBox.Show("La tarea ha sido creada");
                    }

                    listBoxListaTareas.Items.Clear();
                    foreach (TareaReposicionCombustible t in fachada.getListaTareasReposicionCombustible())
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormTareaReposicion_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTanque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTanque.SelectedItem != null){
                comboBoxTipoComb.Enabled = true;
                comboBoxTipoComb.Items.Clear();
                comboBoxTipoComb.Items.Add(((TanqueCombustible)comboBoxTanque.SelectedItem).tipoCombustible);
                comboBoxTipoComb.SelectedItem= ((TanqueCombustible)comboBoxTanque.SelectedItem).tipoCombustible;
                comboBoxTipoComb.Enabled = false;
                comboBoxTipoComb.Show();
            }
        }

        private void listBoxListaTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
