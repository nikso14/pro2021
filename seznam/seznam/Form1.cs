using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seznam
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            a.Add(txtVnos.Text);
            txtKonzola.Text = "dodan k seznamu nov element " + txtVnos.Text;
        }

        //• klik na gumb Izpiši : Izpiše celoten seznam v txtKonzola
        private void btnIzpis_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "elementi seznama " + Environment.NewLine;

            foreach(string x in a)
            {
                txtKonzola.Text += x + Environment.NewLine;
            }
        }

        //klik na gumb Odstrani : iz seznama se odstrani element, katerega niz smo vnesli v
        //txtVnos.V txtKonzola se izpiše "Odstranjen element …."
        private void btnOdstrani_Click(object sender, EventArgs e)
        {
            String niz = txtVnos.Text;
            a.Remove(niz);
            txtKonzola.Text = "Odstranjen element " + niz;
        }

        //• klik na gumb Prvi: v txtKonzola se izpiše vrendost prvega elementa v seznamu
        private void btnPrvi_Click(object sender, EventArgs e)
        {
            if(a.Count > 0)
            {
                String niz = a[0].ToString();
                txtKonzola.Text = "prvi element " + niz;
            }
            else
            {
                txtKonzola.Text = "prazen";
            }
            
        }

        //• klik na gumb Zadnji : v txtKonzola se izpiše zadnji element v seznamu
        private void btnZadnji_Click(object sender, EventArgs e)
        {
            if (a.Count > 0)
            {
                String niz = a[a.Count - 1].ToString();
                txtKonzola.Text = "zadnji element " + niz;
            }
            else
            {
                txtKonzola.Text = "prazen";
            }
        }

        //• klik na gumb "Je prazna?" : V txtKonzola se izpiše "Seznam je prazen", če v seznamu
        //ni nobenega elementa oziroma "Seznam ni prazen", če smo že vnesli element v
        //seznam
        private void btnPrazna_Click(object sender, EventArgs e)
        {
            if (a.Count > 0)
            {
                txtKonzola.Text = "ni prazen";
            }
            else
            {
                txtKonzola.Text = "prazen";
            }
        }

        //• klik na gumb Vsebuje: izpiše v txtKonzola ali seznam vsebuje niz, ki smo ga vnesli v
        //txtVnos
        private void btnVsebuje_Click(object sender, EventArgs e)
        {
            String niz = txtVnos.Text;
            if (a.Contains(niz))
            {
                txtKonzola.Text = "vsebuje element " + niz;
            }
            else
            {
                txtKonzola.Text = "ne vsebuje elementa " + niz;
            }
        }

        //• klik na gumb Lokacija: v txtKonzola izpiše lokacijo niza, ki smo ga vnesli v txtVnos (
        //uporabite metodo IndexOf razreda ArrayList)
        private void btnLokacija_Click(object sender, EventArgs e)
        {
            String niz = txtVnos.Text;
            if (a.Contains(niz))
            {
                int index = a.IndexOf(niz);
                txtKonzola.Text = "indeks niza " + niz + " je " + index;
            }
            else
            {
                txtKonzola.Text = "ne vsebuje elementa " + niz;
            }
        }

        //• klik na gumb Trim: Seznam skrajša na dejansko velikost(uporabite metodo razreda
        //ArrayList TrimToSize() ) in v txtKonzola izpiše "Seznam je skrajšan"
        private void btnTrim_Click(object sender, EventArgs e)
        {
            
            a.TrimToSize();
            txtKonzola.Text = "Seznam je skrajšan";
        }

        //• klik na gumb Statistika: izpiše velikost seznama(lastnost Count) in kapaciteto
        //seznama(lastnost Capacity)
        private void btnStatistika_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = a.Count.ToString() + a.Capacity.ToString();
        }








        
        
    }
}
