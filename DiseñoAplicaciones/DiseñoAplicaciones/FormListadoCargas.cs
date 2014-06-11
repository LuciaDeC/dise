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
    public partial class FormListadoCargas : Form
    {
        private FachadaUISistema fachada;

        public FormListadoCargas()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();

            listCargas.Items.Clear();
            foreach (Carga carga in fachada.getListaCargas())
            {
                listCargas.Items.Add(carga);
            }
            listCargas.Show();

            comboSurtidor.Items.Clear();
            foreach (Surtidor s in fachada.getListaSurtidores())
            {
                comboSurtidor.Items.Add(s);
            }

            comboSurtidor.Show();

            dateTimePickerHasta.Value = DateTime.Now;
        }

        private void listCargas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormListadoCargas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDesde.Value.ToString("dd-MM-yyyy").Equals("01-01-2014") && dateTimePickerHasta.Value.ToString("dd-MM-yyyy").Equals(DateTime.Now.ToString("dd-MM-yyyy")) && textLtsDesde.Text == "" && textLtsHasta.Text == "" && comboSurtidor.Text =="Surtidor" && comboManguera.Text =="Manguera")
            {

                listCargas.Items.Clear();
                foreach (Carga carga in fachada.getListaCargas())
                {
                    listCargas.Items.Add(carga);
                }

                listCargas.Show();
            }
            else
            {
               DateTime fechaDesde = dateTimePickerDesde.Value;
               DateTime fechaHasta = dateTimePickerHasta.Value;
               int litrosDesde ;
               int litrosHasta; 
                Surtidor surtidor;
                Manguera manguera;

                if(textLtsDesde.Text == ""){
                    litrosDesde =0;
                }else{
                    litrosDesde = Convert.ToInt32(textLtsDesde.Text.Trim());
                }
                  if(textLtsHasta.Text == ""){
                    litrosHasta =0;
                }else{
                    litrosHasta = Convert.ToInt32(textLtsHasta.Text.Trim());
                }

                if (comboSurtidor.Text == "Surtidor"){
                      surtidor =null;
                  }else{
                      surtidor = (Surtidor)comboSurtidor.SelectedItem;
                  }
                         
                if (comboManguera.Text == "Manguera"){
                    manguera = null;
                  }else{
                      manguera = (Manguera)comboManguera.SelectedItem;
                  }
                
            
             
                List<Carga> listaFiltrada = fachada.listaCargaFiltrada(fechaDesde, fechaHasta, litrosDesde, litrosHasta, surtidor, manguera);

                listCargas.Items.Clear();
                foreach (Carga carga in listaFiltrada)
                {
                    listCargas.Items.Add(carga);
                }
                listCargas.Show();
            }

            String litrosTxt;
            if(textLtsDesde.Text == "" || textLtsHasta.Text == ""){
                litrosTxt= " sin filtro de litros ";
            }else{
                litrosTxt = " entre "+ textLtsDesde.Text + " y "+ textLtsHasta.Text +" litros ";
            }

            lblresumenFiltro.Text = "Se muestran los resultados desde " + dateTimePickerDesde.Value.ToString("dd-MM-yyyy") + " hasta " + dateTimePickerHasta.Value.ToString("dd-MM-yyyy") + litrosTxt + "para los surtidores y mangueras seleccionadas";
           
            textLtsDesde.Text = "";
            textLtsHasta.Text = "";
            comboSurtidor.Text = "Surtidor";
            comboManguera.Text = "Manguera";


        }

        private void comboSurtidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSurtidor.SelectedItem != null)
            {
                comboManguera.Items.Clear();
                foreach (Manguera m in ((Surtidor)comboSurtidor.SelectedItem).listaMangueras)
                {
                    comboManguera.Items.Add(m);
                }
                comboManguera.Show();
            }
        }

        private void textLtsHasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Filtros_Enter(object sender, EventArgs e)
        {

        }
    }
}
