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
    public partial class FormTanqueCombustible : Form
    {
        private FachadaUISistema fachada;
        private TanqueCombustible tanqueSeleccionado;

        public FormTanqueCombustible()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            tanqueSeleccionado = null; 

            comboTiposCombustible.Items.Clear();
            foreach (TipoCombustible t in fachada.getListaTiposCombustible()){
                comboTiposCombustible.Items.Add(t);
            }
            comboTiposCombustible.Show();

            listaTanques.Items.Clear();
            foreach (TanqueCombustible t2 in fachada.getListaTanquesCombustible()){
                listaTanques.Items.Add(t2);
            }
            listaTanques.Show();
        }
        

        private void AgregarTanqueCombustible_Load(object sender, EventArgs e)
        {

        }

        private void AgregarTanqueCombustible_Load_1(object sender, EventArgs e)
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
                if ((textCapacidad.Text.Trim().Length > 0) && (descripcion.Length > 0) && (textNumero.Text.Trim().Length > 0))
                {
                    int capacidad = Convert.ToInt32(textCapacidad.Text.Trim());
                    int numero = Convert.ToInt32(textNumero.Text.Trim());
                    
                    if (tanqueSeleccionado == null)
                    {
                        fachada.crearTanqueCombustible(numero, descripcion, capacidad, (TipoCombustible)comboTiposCombustible.SelectedItem);
                        MessageBox.Show("El tanque ha sido creado");

                    }
                    else {
                        fachada.editarTanqueCombustible(numero, descripcion, capacidad, (TipoCombustible)comboTiposCombustible.SelectedItem, tanqueSeleccionado);
                        MessageBox.Show("El tanque ha sido editado");
                    }
                    borrarDatos();
                   
                    listaTanques.Items.Clear();
                    foreach (TanqueCombustible t in fachada.getListaTanquesCombustible()){
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

        private void comboTiposCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tanqueSeleccionado != null)
            {
                if(fachada.contieneMangueras(tanqueSeleccionado)){
                    MessageBox.Show("No se puede eliminar el tanque, el mismo tiene mangueras asociadas");
                }else{
                    fachada.eliminarTanqueCombustible(tanqueSeleccionado.idTanque);
                    MessageBox.Show("Se ha eliminado el elemento seleccionado de forma correcta!");
                    listaTanques.Items.Clear();
                    foreach (TanqueCombustible t2 in fachada.getListaTanquesCombustible())
                    {
                       listaTanques.Items.Add(t2);
                    }
                    listaTanques.Show();
                }
                tanqueSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tanque");
            }
        }

        private void listaTanques_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaTanques.SelectedItem != null)
            {
                tanqueSeleccionado = (TanqueCombustible)listaTanques.SelectedItem;
                textCapacidad.Text = (tanqueSeleccionado).capacidad.ToString();
                textDescripcion.Text = (tanqueSeleccionado).descripcion.ToString();
                textNumero.Text = (tanqueSeleccionado).idTanque.ToString();
                comboTiposCombustible.SelectedItem = tanqueSeleccionado.tipoCombustible;
            }
        }

        private void borrarDatos() {
            textCapacidad.Clear();
            textDescripcion.Clear();
            textNumero.Clear();
            comboTiposCombustible.SelectedItem = null; 
        }

    }
}
