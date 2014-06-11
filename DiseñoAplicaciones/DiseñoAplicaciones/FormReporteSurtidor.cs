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
    public partial class FormReporteSurtidor : Form
    {
        private FachadaUISistema fachada;
        private DateTime fechaD;
        private DateTime fechaH;


        public FormReporteSurtidor()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            comboBoxSurtidor.Items.Clear();
            foreach (Surtidor s in fachada.getListaSurtidores())
            {
                comboBoxSurtidor.Items.Add(s);
            }
            comboBoxSurtidor.Show();
            String fechaDesde = "01" + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year);
            fechaD = Convert.ToDateTime(fechaDesde);
            dateTimePickerFechaDesde.Value = fechaD;
            dateTimePickerFechaHasta.Value = DateTime.Now;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if ((Surtidor)comboBoxSurtidor.SelectedItem != null)
            {
                fechaD = dateTimePickerFechaDesde.Value.Date;
                fechaH = dateTimePickerFechaHasta.Value.Date;

                if (fechaH < fechaD)
                {
                    MessageBox.Show("Fechas inválidas, verifique los datos");
                }
                else
                {
                    Surtidor s = (Surtidor)comboBoxSurtidor.SelectedItem;
                    
                    foreach(String carga in fachada.obtenerDatosCargasReporteSurtidor(s, fechaD, fechaH)){
                        listaCargas.Items.Add(carga);
                    }
                    foreach (String carga in fachada.obtenerDatosTareasReporteSurtidor(s, fechaD, fechaH))
                    {
                        listaTareas.Items.Add(carga);
                    }
                    
                    if(listaTareas.Items.Count == 0 || listaCargas.Items.Count == 0)
                    {
                        MessageBox.Show("No hay datos para mostrar de este surtidor");
                    }
                }
            }

            else
            {
                MessageBox.Show("No ha seleccionado ningún surtidor");
            }
        }

        private void FormReporteSurtidor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
