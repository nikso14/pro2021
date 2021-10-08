using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fraktali
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double alfa;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int risaniX(double xr)
        {
            return (int)Math.Round(this.Width * xr);
        }

        private int risaniY(double yr)
        {
            return (int)Math.Round(this.Height- this.Height * yr);
        }

        public void ObratLevo(double kot)
        {
            alfa = alfa + kot;
        }
        public void Premik(double d, Graphics g)
        {
            double stariX = x;
            double stariY = y;
            x = x + Math.Cos(alfa * Math.PI / 180);
            y = y + Math.Sin(alfa * Math.PI / 180);
            int x1 = risaniX(stariX);
            int y1 = risaniY(stariY);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            Pen p = new Pen(Color.Black, 3);
            g.DrawLine(p, x1, y1, x2, y2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            x = 0.5; y = 0.5; alfa = 0;
            Premik(0.5, g);
        }
    }
}
