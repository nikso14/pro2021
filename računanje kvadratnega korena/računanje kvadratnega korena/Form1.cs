using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace računanje_kvadratnega_korena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKoren_Click(object sender, EventArgs e)
        {
            try
            {
                int stevilo = int.Parse(txtVnos.Text);
                if(stevilo < 0)
                {
                    throw new NegativnoException();
                }
                txtRezultat.Text = Math.Sqrt(stevilo).ToString();
            }catch(FormatException f)
            {
                MessageBox.Show("napačen format");
            }
            catch (NegativnoException f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
