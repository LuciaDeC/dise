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
    public partial class FormPantalla : Form, IObserver<Tanque>
    {
        public void OnNext(Tanque tanque)
        {
            listTanques.Items.Clear();
            listExpendidos.Items.Clear();
            listTanqDisp.Items.Clear();
            foreach (TanqueCombustible t in fachada.getListaTanquesCombustible())
            {
                tanque.Subscribe(this);
                listTanques.Items.Add(t);
            }

            if (comboSurtidores.SelectedItem != null)
            {
                listTanqDisp.Items.Clear();
                listExpendidos.Items.Clear();

                foreach (Manguera m in ((Surtidor)comboSurtidores.SelectedItem).listaMangueras)
                {
                    if (!listTanqDisp.Items.Contains(m.tanque))
                        listTanqDisp.Items.Add(m.tanque);
                }
                foreach (String t in fachada.obtenerLitrosPorTipo(((Surtidor)comboSurtidores.SelectedItem).listaMangueras))
                {
                    listExpendidos.Items.Add(t);
                }
            }
            listTanqDisp.Show();
            listExpendidos.Show();
            listTanques.Show();


        }
        public void OnError(Exception e)
        {
        }

        public void OnCompleted()
        {
        }

        private FachadaUISistema fachada;
        public FormPantalla()
        {
            InitializeComponent();
            fachada = FachadaUISistema.getFachada();
            foreach (TanqueCombustible tanque in fachada.getListaTanquesCombustible())
            {
              tanque.Subscribe(this);
              listTanques.Items.Add(tanque);
            }

            comboSurtidores.Items.Clear();
            foreach (Surtidor s in fachada.getListaSurtidores())
            {
                comboSurtidores.Items.Add(s);
            }
        }

        private void FormPantalla_Load(object sender, EventArgs e)
        {


        }

        private void listTanques_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listSurtidores_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSurtidores.SelectedItem != null)
            {
                listTanqDisp.Items.Clear();
                listExpendidos.Items.Clear();
               
                foreach (Manguera m in ((Surtidor)comboSurtidores.SelectedItem).listaMangueras)
                {
                    if (!listTanqDisp.Items.Contains(m.tanque))
                        listTanqDisp.Items.Add(m.tanque);
                }
                foreach (String t in fachada.obtenerLitrosPorTipo(((Surtidor)comboSurtidores.SelectedItem).listaMangueras)) {
                    listExpendidos.Items.Add(t);
                }
            }
            listTanqDisp.Show();
            listExpendidos.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listTanqDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listExpendidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
