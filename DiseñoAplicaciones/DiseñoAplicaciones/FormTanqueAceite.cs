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
    public partial class FormTanqueAceite : Form
    {
        private FachadaUISistema fachada;
        private TanqueAceite tanqueSeleccionado;

        public FormTanqueAceite()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            tanqueSeleccionado = null;
            listaTanques.Items.Clear();
            foreach (TanqueAceite t2 in fachada.getListaTanquesAceite())
            {
                listaTanques.Items.Add(t2);
            }
            listaTanques.Show();

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String descripcion = textDescripcion.Text.Trim();
                
                if ((textCapacidad.Text.Trim().Length > 0) && (descripcion.Length > 0) && (textNumero.Text.Trim().Length > 0) && (textBoxViscosidad.Text.Trim().Length>0))
                {
                    int capacidad = Convert.ToInt32(textCapacidad.Text.Trim());
                    int numero = Convert.ToInt32(textNumero.Text.Trim());
                    int viscosidad = Convert.ToInt32(textBoxViscosidad.Text.Trim());

                    if (tanqueSeleccionado == null)
                    {
                        fachada.crearTanqueAceite(numero, descripcion, capacidad, viscosidad);
                        MessageBox.Show("El tanque ha sido creado");

                    }
                    else
                    {
                       //fachada.editarTanqueAceite(numero, descripcion, capacidad, viscosidad, tanqueSeleccionado);
                        MessageBox.Show("El tanque ha sido editado");
                    }
                    borrarDatos();

                    listaTanques.Items.Clear();
                    foreach (TanqueAceite t in fachada.getListaTanquesAceite())
                    {
                        listaTanques.Items.Add(t);
                    }
                    listaTanques.Show();
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
            tanqueSeleccionado = null;
            listaTanques.SelectedItem = null;
        }

        private void borrarDatos()
        {
            textCapacidad.Clear();
            textDescripcion.Clear();
            textNumero.Clear();
            textBoxViscosidad.Clear();
        }
    }
}
