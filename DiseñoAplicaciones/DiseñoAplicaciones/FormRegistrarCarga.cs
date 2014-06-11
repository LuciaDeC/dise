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
    public partial class FormRegistrarCarga : Form
    {
        private FachadaUISistema fachada;

        public FormRegistrarCarga()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();

            listaCargasRealizadas.Items.Clear();
            foreach (Carga c in fachada.getListaCargas())
            {
                listaCargasRealizadas.Items.Add(c);
            }
            listaCargasRealizadas.Show();

            listaCargasRealizadas.HorizontalScrollbar = true;

            comboUsuarios.Items.Clear();
            foreach (Usuario u in fachada.getListaUsuarios())
            {
                comboUsuarios.Items.Add(u);
            }
            comboUsuarios.Show();

            comboClientes.Items.Clear();
            foreach (Cliente c in fachada.getListaClientes())
            {
                comboClientes.Items.Add(c);
            }
            comboClientes.Show();

            comboSurtidor.Items.Clear();
            foreach (Surtidor s in fachada.getListaSurtidores())
            {
                comboSurtidor.Items.Add(s);
            }
            comboSurtidor.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboManguera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRegistrarCarga_Load(object sender, EventArgs e)
        {

        }

        private void buttonRealizarCarga_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboClientes.SelectedItem != null && comboVehiculos.SelectedItem != null && comboUsuarios.SelectedItem != null && comboManguera.SelectedItem != null && comboSurtidor.SelectedItem != null && (textCantidad.Text.Trim().Length > 0) && (textNumero.Text.Trim().Length > 0))
                {
                    int numero = Convert.ToInt32(textNumero.Text.Trim());
                    int cantidad = Convert.ToInt32(textCantidad.Text.Trim());

                    if(cantidad < 0){
                        MessageBox.Show("La cantidad no puede ser negativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else{
                        fachada.realizarCarga((Usuario)comboUsuarios.SelectedItem, (Cliente)comboClientes.SelectedItem, (Vehiculo)comboVehiculos.SelectedItem, (Manguera)comboManguera.SelectedItem, (Surtidor)comboSurtidor.SelectedItem, cantidad, numero);
                        MessageBox.Show("Carga realizada con éxito");
                        borrarDatos();
                    }
                    listaCargasRealizadas.Items.Clear();
                    foreach (Carga c in fachada.getListaCargas())
                    {
                        listaCargasRealizadas.Items.Add(c);
                    }
                    listaCargasRealizadas.Show();
                  
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
            comboUsuarios.SelectedItem = null;
            comboManguera.SelectedItem = null;
            comboClientes.SelectedItem = null;
            comboSurtidor.SelectedItem = null;
            comboVehiculos.SelectedItem = null;
            textCantidad.Clear();
            textNumero.Clear();
        }

        private void comboClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboClientes.SelectedItem != null)
            {
                comboVehiculos.Items.Clear();
                foreach (Vehiculo v in fachada.getListaVehiculosCliente((Cliente) comboClientes.SelectedItem))
                {
                    comboVehiculos.Items.Add(v);
                }
                comboVehiculos.Show();
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSurtidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSurtidor.SelectedItem != null){
            comboManguera.Items.Clear();
            foreach (Manguera m in ((Surtidor)comboSurtidor.SelectedItem).listaMangueras)
            {
                comboManguera.Items.Add(m);
            }
            comboManguera.Show();
            }
        }
    }
}
