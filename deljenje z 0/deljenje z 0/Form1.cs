using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deljenje_z_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {
                int deljenec = int.Parse(txtDeljenec.Text);
                int deljitelj = int.Parse(txtDeljitelj.Text);
                int rezultat = deljenec / deljitelj;
                labRezultat.Text = rezultat.ToString();
            } catch (FormatException f)
            {
                MessageBox.Show("napačen format");
            }
            catch (DivideByZeroException f)
            {
                MessageBox.Show("deljenje z 0");
            }
        }
    }
}
