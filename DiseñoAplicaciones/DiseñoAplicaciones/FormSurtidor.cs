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
    public partial class FormSurtidor : Form
    {
        private FachadaUISistema fachada;
        private Surtidor surtidorSeleccionado;

        public FormSurtidor()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            surtidorSeleccionado = null;
            
            listaSurtidores.Items.Clear();
            foreach (Surtidor s in fachada.getListaSurtidores()){
                listaSurtidores.Items.Add(s);
            }
            listaSurtidores.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                if (textNroSerie.Text.Trim().Length > 0)
                {
                    int numero = Convert.ToInt32(textNroSerie.Text.Trim());

                    if(surtidorSeleccionado==null){
                        fachada.crearSurtidor(numero);
                        MessageBox.Show("El Surtidor ha sido creado");
                    }
                    else
                    {
                        fachada.editarSurtidor(numero,surtidorSeleccionado);
                        MessageBox.Show("Surtidor editado");
                    }
                    
                    listaSurtidores.Items.Clear();
                    foreach (Surtidor s in fachada.getListaSurtidores())
                    {
                        listaSurtidores.Items.Add(s);
                    }
                    listaSurtidores.Show();
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
            surtidorSeleccionado = null;
            listaSurtidores.SelectedItem = null;
        }

        private void FormSurtidor_Load(object sender, EventArgs e)
        {

        }

        private void listaSurtidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaSurtidores.SelectedItem != null)
            {
                surtidorSeleccionado =(Surtidor) listaSurtidores.SelectedItem;
                textNroSerie.Text = (surtidorSeleccionado).numeroSerie.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (surtidorSeleccionado != null)
            {
                fachada.eliminarSurtidor(surtidorSeleccionado.numeroSerie);
                listaSurtidores.Items.Clear();
                foreach (Surtidor s in fachada.getListaSurtidores())
                {
                    listaSurtidores.Items.Add(s);
                }
                listaSurtidores.Show();
                surtidorSeleccionado = null;
                borrarDatos();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un surtidor");
            } 
        }

        private void borrarDatos() {
            textNroSerie.Clear();
        }
    }
}
