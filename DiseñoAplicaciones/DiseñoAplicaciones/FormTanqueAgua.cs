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
    public partial class FormTanqueAgua : Form
    {
        private FachadaUISistema fachada;
        private TanqueAgua tanqueSeleccionado;

        public FormTanqueAgua()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            tanqueSeleccionado = null;

            listaTanques.Items.Clear();
            //foreach (TanqueAgua t2 in fachada.getListaTanquesAgua())
            //{
              //  listaTanques.Items.Add(t2);
            //}
          //  listaTanques.Show();

            comboBoxLocalizacion.Items.Clear();
            comboBoxLocalizacion.Items.Add("Subterráneo");
            comboBoxLocalizacion.Items.Add("de Superficie");
            comboBoxLocalizacion.Items.Add("Elevado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                String localizacion = (String)comboBoxLocalizacion.SelectedItem;

                if ((textCapacidad.Text.Trim().Length > 0) && (textDescripcion.Text.Trim().Length > 0) && (textNumero.Text.Trim().Length > 0))
                {
                    int capacidad = Convert.ToInt32(textCapacidad.Text.Trim());
                    int numero = Convert.ToInt32(textNumero.Text.Trim());
                    String descripcion = textDescripcion.Text.Trim();
                    

                    if (tanqueSeleccionado == null)
                    {
                        fachada.crearTanqueAgua(numero, descripcion, capacidad, (String)comboBoxLocalizacion.SelectedItem);
                        MessageBox.Show("El tanque ha sido creado");

                    }
                    else
                    {
                       // fachada.editarTanqueAgua(numero, descripcion, capacidad, (String)comboBoxLocalizacion.SelectedItem);
                        MessageBox.Show("El tanque ha sido editado");
                    }
                    borrarDatos();

                    listaTanques.Items.Clear();
                    foreach (TanqueAgua t in fachada.getListaTanquesAgua())
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
            comboBoxLocalizacion.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
