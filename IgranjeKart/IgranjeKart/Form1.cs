using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgranjeKart
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Kup kup1 = new Kup();
        Kup kup2 = new Kup();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vrednost je naključno število med 1 in 12, barva je naključno število med 1 in 4
            Karta k = new Karta((Vrednosti) r.Next(1, 13), (Barve)r.Next(1, 5));
            MessageBox.Show(k.Ime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rezultat = "";
            List<Karta> kup = new List<Karta>();
            for(int k = 0; k<5; k++)
            {
                Karta karta=
                    new Karta((Vrednosti)r.Next(1, 13), (Barve)r.Next(1, 5));
                kup.Add(karta);
                rezultat += karta.Ime + Environment.NewLine;
            }

            kup.Sort(new Primerjava());
            rezultat += Environment.NewLine + Environment.NewLine + "Urejen kup" + Environment.NewLine + Environment.NewLine;
            foreach(Karta x in kup)
            {
                rezultat += x.Ime + Environment.NewLine;
            }
            MessageBox.Show(rezultat);
        }

        private void btnPonastaviKup1_Click(object sender, EventArgs e)
        {
            int štKart = r.Next(1, 11);
            kup1 = new Kup(new Karta[] { });
            for(int i = 0; i<štKart; i++)
            {
                kup1.Add(new Karta((Vrednosti)r.Next(1, 14), (Barve)r.Next(1,4)));
            }
            listKup1.Items.Clear();
            foreach (String x in kup1.ImenaKart())
            {
                listKup1.Items.Add(x);
            }
        }

        private void btnMešajKup1_Click(object sender, EventArgs e)
        {
            kup1.Mešaj();
            listKup1.Items.Clear();
            foreach (String x in kup1.ImenaKart())
            {
                listKup1.Items.Add(x);
            }
        }

        private void btnPonastaviKup2_Click(object sender, EventArgs e)
        {
            kup2 = new Kup();
            listKup2.Items.Clear();
            foreach (String x in kup2.ImenaKart())
            {
                listKup2.Items.Add(x);
            }
        }

        private void btnMešajKup2_Click(object sender, EventArgs e)
        {
            kup2.Mešaj();
            listKup2.Items.Clear();
            foreach (String x in kup2.ImenaKart())
            {
                listKup2.Items.Add(x);
            }
        }

        private void btnNaKup2_Click(object sender, EventArgs e)
        {
            int indeks = listKup1.SelectedIndex;
            kup2.Add(kup1.Deli(indeks));
            listKup1.Items.Clear();
            foreach (String x in kup1.ImenaKart())
            {
                listKup1.Items.Add(x);
            }
            listKup2.Items.Clear();
            foreach (String x in kup2.ImenaKart())
            {
                listKup2.Items.Add(x);
            }
        }

        private void btnNaKup1_Click(object sender, EventArgs e)
        {
            int indeks = listKup2.SelectedIndex;
            kup1.Add(kup2.Deli(indeks));
            listKup1.Items.Clear();
            foreach (String x in kup1.ImenaKart())
            {
                listKup1.Items.Add(x);
            }
            listKup2.Items.Clear();
            foreach (String x in kup2.ImenaKart())
            {
                listKup2.Items.Add(x);
            }
        }
    }
}
