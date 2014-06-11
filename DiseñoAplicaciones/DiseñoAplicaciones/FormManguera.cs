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
    public partial class FormManguera : Form
    {
        private FachadaUISistema fachada;
        private Manguera mangueraSeleccionada;

        public FormManguera()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            mangueraSeleccionada = null;

            comboTanques.Items.Clear();
            foreach (TanqueCombustible t in fachada.getListaTanquesCombustible())
            {
                comboTanques.Items.Add(t);
            }
            comboTanques.Show();

            listaMangueras.Items.Clear();
            foreach(Manguera m in fachada.getListaMangueras()){
                listaMangueras.Items.Add(m);
            }
            listaMangueras.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textManguera.Text.Trim().Length > 0))
                {
                    int manguera = Convert.ToInt32(textManguera.Text.Trim());
                    int tanque = ((TanqueCombustible)comboTanques.SelectedItem).idTanque;

                    if (mangueraSeleccionada == null)
                    {
                        
                        fachada.crearManguera(manguera, tanque);
                        MessageBox.Show("La manguera ha sido creada");
                        borrarDatos();
                    }
                    else {

                        fachada.editarManguera(manguera, tanque, mangueraSeleccionada);
                        MessageBox.Show("La manguera ha sido editada");
                        borrarDatos();
                    }
                   
                    listaMangueras.Items.Clear();
                    foreach (Manguera m in fachada.getListaMangueras()){
                        listaMangueras.Items.Add(m);
                    }
                    listaMangueras.Show();
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
            mangueraSeleccionada = null;
            listaMangueras.SelectedItem = null;
        }

        private void borrarDatos()
        {
            textManguera.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mangueraSeleccionada != null)
            {
                fachada.eliminarManguera(mangueraSeleccionada.numeroManguera);
                MessageBox.Show("La menguera ha sido eliminada");
                borrarDatos();

                listaMangueras.Items.Clear();
                foreach (Manguera m in fachada.getListaMangueras())
                {
                    listaMangueras.Items.Add(m);
                }
                listaMangueras.Show();
                mangueraSeleccionada = null;
                comboTanques.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una manguera");
            } 
        }

        private void listaMangueras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaMangueras.SelectedItem != null)
            {
                mangueraSeleccionada = (Manguera)listaMangueras.SelectedItem;
                textManguera.Text = (mangueraSeleccionada).numeroManguera.ToString();
                comboTanques.SelectedItem = mangueraSeleccionada.tanque;
                comboTanques.SelectedItem = (mangueraSeleccionada).tanque.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
