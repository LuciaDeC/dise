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
    public partial class FormTareaTratamientoAceite : Form
    {
        private FachadaUISistema fachada;
        private TanqueAceite tanqueSeleccionado;

        public FormTareaTratamientoAceite()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            tanqueSeleccionado = null;

            listBoxTanquesAceite.Items.Clear();
            foreach (TanqueAceite tanque in fachada.getListaTanquesAceite())
            {
                listBoxTanquesAceite.Items.Add(tanque);
            }
            listBoxTanquesAceite.Show();
        
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TanqueAceite t in listBoxNuevaListaTanques .Items)
                {
                    fachada.crearTareaTratamientoAceite(t);
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
            if (listBoxTanquesAceite.SelectedItem != null)
            {
                tanqueSeleccionado = (TanqueAceite)listBoxTanquesAceite.SelectedItem;
                listBoxNuevaListaTanques.Items.Add(tanqueSeleccionado);
                listBoxTanquesAceite.Items.Remove(tanqueSeleccionado);

            }
            else
            {
                MessageBox.Show("Debe seleccionar un tanque");
            }

            tanqueSeleccionado = null;
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {

            if (listBoxNuevaListaTanques.SelectedItem != null)
            {
                tanqueSeleccionado = (TanqueAceite)listBoxNuevaListaTanques.SelectedItem;
                listBoxNuevaListaTanques.Items.Remove(tanqueSeleccionado);
                listBoxTanquesAceite.Items.Add(tanqueSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tanque");
            }
            tanqueSeleccionado = null;
        }
    }
}
