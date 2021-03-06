﻿using System;
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
    public partial class FormTareaTratamientoAgua : Form
    {
        private FachadaUISistema fachada;
        private TanqueAgua tanqueSeleccionado;

        public FormTareaTratamientoAgua()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            tanqueSeleccionado = null;
            
            listBoxTanquesAgua.Items.Clear();
            foreach (TanqueAgua tanque in fachada.getListaTanquesAgua())
            {
                listBoxTanquesAgua.Items.Add(tanque);
            }
            listBoxTanquesAgua.Show();
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TanqueAgua t in listBoxNuevaTanquesAgua.Items) {
                    fachada.crearTareaTratamientoAgua(t);
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
            if (listBoxTanquesAgua.SelectedItem != null)
            {
                tanqueSeleccionado = (TanqueAgua)listBoxTanquesAgua.SelectedItem;
                listBoxNuevaTanquesAgua.Items.Add(tanqueSeleccionado);
                listBoxTanquesAgua.Items.Remove(tanqueSeleccionado);
              
            }
            else {
                MessageBox.Show("Debe seleccionar un tanque");
            }
            
            tanqueSeleccionado = null;
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            if (listBoxNuevaTanquesAgua.SelectedItem != null)
            {
                tanqueSeleccionado = (TanqueAgua)listBoxNuevaTanquesAgua.SelectedItem;
                listBoxNuevaTanquesAgua.Items.Remove(tanqueSeleccionado);
                listBoxTanquesAgua.Items.Add(tanqueSeleccionado);
            }
            else {
                MessageBox.Show("Debe seleccionar un tanque");
            }
            tanqueSeleccionado = null;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBoxNuevaTanquesAgua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
