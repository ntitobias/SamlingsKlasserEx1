using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamlingsKlasserEx1
{
    public partial class Form1 : Form
    {
        //Skapa en lista av int
        List<int> lista = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {

            //Om värdet är av typen int ska det läggas till i listan
            try {
                lista.Add(int.Parse(tbxLäggTill.Text));
            }
            catch
            {
                MessageBox.Show("Felaktig inmatning!", "Caption");
            }
            //Skriv ut listan
            FyllListan();
        }

        private void FyllListan()
        {
            //Nollställ labeln lblList
            lblLista.Text = "";

            //Fyll listboxen med innehållet från listan
            for(int i = 0; i < lista.Count; i++)
            {
                lblLista.Text += lista[i] + "\r\n";
            }
        }

        private void btnKollaVärde_Click(object sender, EventArgs e)
        {
            //Kolla om värdet i textboxen finns i listan
            try
            {
                lblLista.Text = "Talet " + int.Parse(tbxKollaVärde.Text)
                    + " finns i listan " + lista.Contains(int.Parse(tbxKollaVärde.Text));
            }
            catch
            {
                MessageBox.Show("Felaktig inmatning!", "Caption");
            }
        }
    }
}
