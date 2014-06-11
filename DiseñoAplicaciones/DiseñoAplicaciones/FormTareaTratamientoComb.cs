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
    public partial class FormTareaTratamientoComb : Form
    {
        private FachadaUISistema fachada;
        private TanqueCombustible tanqueSeleccionado;

        public FormTareaTratamientoComb()
        {
            InitializeComponent();
             fachada = FachadaUISistema.getFachada();
            tanqueSeleccionado = null;
            
            listBoxTanquesComb.Items.Clear();
            foreach (TanqueCombustible tanque in fachada.getListaTanquesCombustible())
            {
                listBoxTanquesComb.Items.Add(tanque);
            }
            listBoxTanquesComb.Show();
        
            
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TanqueCombustible t in listBoxNuevaTanquesComb.Items)
                {
                   fachada.crearTareaTratamientoCombustible(t);
                }
                MessageBox.Show("Se ha realizado la tarea con éxito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            if (listBoxTanquesComb.SelectedItem != null)
            {
                tanqueSeleccionado = (TanqueCombustible)listBoxTanquesComb.SelectedItem;
                listBoxNuevaTanquesComb.Items.Add(tanqueSeleccionado);
                listBoxTanquesComb.Items.Remove(tanqueSeleccionado);

            }
            else
            {
                MessageBox.Show("Debe seleccionar un tanque");
            }

            tanqueSeleccionado = null;
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            if (listBoxNuevaTanquesComb.SelectedItem != null)
            {
                tanqueSeleccionado = (TanqueCombustible)listBoxNuevaTanquesComb.SelectedItem;
                listBoxNuevaTanquesComb.Items.Remove(tanqueSeleccionado);
                listBoxTanquesComb.Items.Add(tanqueSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tanque");
            }
            tanqueSeleccionado = null;
        }
    }
}
