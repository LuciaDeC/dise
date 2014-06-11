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
    public partial class FormAsignarMangueras : Form
    {

        private FachadaUISistema fachada;
        private Surtidor surtidorSeleccionado;
        private Manguera mangueraSeleccionada;

        public FormAsignarMangueras()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            surtidorSeleccionado = null;
            mangueraSeleccionada = null;
            comboSurtidor.Items.Clear();
            foreach (Surtidor s in fachada.getListaSurtidores())
            {
                comboSurtidor.Items.Add(s);
            }
            comboSurtidor.Show();
        }

        private void FormAsignarMangueras_Load(object sender, EventArgs e)
        {

        }

        private void comboSurtidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAsignadas.Items.Clear();
            listMangueras.Items.Clear();

            surtidorSeleccionado = (Surtidor)comboSurtidor.SelectedItem;
            foreach (Manguera m in surtidorSeleccionado.listaMangueras)
            {
                listAsignadas.Items.Add(m);
            }

            foreach (Manguera m in fachada.getListaMangueras())
            {
                if (!surtidorSeleccionado.listaMangueras.Contains(m))
                    listMangueras.Items.Add(m);
            }
            listAsignadas.Show();
            listMangueras.Show();

        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            if (comboSurtidor.SelectedItem != null && listMangueras.SelectedItem != null)
            {
                mangueraSeleccionada = (Manguera)listMangueras.SelectedItem;
                surtidorSeleccionado = (Surtidor)comboSurtidor.SelectedItem;
                if (!surtidorSeleccionado.listaMangueras.Contains(mangueraSeleccionada))
                {
                    fachada.agregarManguera(surtidorSeleccionado, mangueraSeleccionada);
                    listAsignadas.Items.Add(mangueraSeleccionada);
                    listMangueras.Items.Remove(mangueraSeleccionada);
                    comboSurtidor.Items.Clear();
                    foreach (Surtidor s in fachada.getListaSurtidores())
                    {
                        comboSurtidor.Items.Add(s);
                    }
                    comboSurtidor.Show();
                    comboSurtidor.SelectedItem = surtidorSeleccionado;
                }
                else
                {
                    MessageBox.Show("El surtidor ya contiene esa manguera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Surtidor y una manguera a Asignar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            if (comboSurtidor.SelectedItem != null && listAsignadas.SelectedItem != null)
            {
                mangueraSeleccionada = (Manguera)listAsignadas.SelectedItem;
                surtidorSeleccionado = (Surtidor)comboSurtidor.SelectedItem;

                if (surtidorSeleccionado.listaMangueras.Contains(mangueraSeleccionada))
                {
                    fachada.quitarManguera(surtidorSeleccionado, mangueraSeleccionada);
                    listAsignadas.Items.Remove(mangueraSeleccionada);
                    listMangueras.Items.Add(mangueraSeleccionada);
                    comboSurtidor.Items.Clear();
                    foreach (Surtidor s in fachada.getListaSurtidores())
                    {
                        comboSurtidor.Items.Add(s);
                    }
                    comboSurtidor.Show();
                    comboSurtidor.SelectedItem = surtidorSeleccionado;
                    mangueraSeleccionada = null;
                }
                else
                {
                    MessageBox.Show("El surtidor no contiene a la manguera seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Surtidor y una manguera a Asignar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
