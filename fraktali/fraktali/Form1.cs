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
            x = x + d*Math.Cos(alfa * Math.PI / 180);
            y = y + d*Math.Sin(alfa * Math.PI / 180);
            int x1 = risaniX(stariX);
            int y1 = risaniY(stariY);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            Pen p = new Pen(Color.Black, 3);
            g.DrawLine(p, x1, y1, x2, y2);
        }

        public void Koch(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                Premik(korak, g);
                return;
            }
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
            ObratLevo(-120);
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);

        }

        public void Drevo(int n, double x, double y, double a, double dolžina, Graphics g)
        {
            int kot_upogiba = 45;
            double pojemek = 0.6;
            double cx = x + dolžina * Math.Cos(a * Math.PI / 180);
            double cy = y + dolžina * Math.Sin(a * Math.PI / 180);
            int x1 = risaniX(cx);
            int y1 = risaniY(cy);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(255), r.Next(255), 100);
            Pen p = new Pen(c,(float) Math.Pow(n, 1.2));
            g.DrawLine(p, x1, y1, x2, y2);
            if (n == 0) return;
            Drevo(n - 1, cx, cy, a - kot_upogiba, dolžina * pojemek, g);
            Drevo(n - 1, cx, cy, a + kot_upogiba, dolžina * pojemek, g);
            Drevo(n - 1, cx, cy, a, dolžina *(1 - pojemek), g);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /*x = 0.5; y = 0.1; alfa = 0;
            for(int k = 0; k < 6; k++)
            {
                double korak = 0.2;
                Premik(korak, g);
                ObratLevo(360 / 6);
            }*/



            //naključno


            /*Random r = new Random();
            x = 0.5;y = 0.5; alfa = 0;
            for(int k = 0; k < 1000; k++)
            {
                ObratLevo(r.Next(360));
                Premik(0.1, g);
            }
            */

            //koch zvezda
            /*x = 0.2;y = 0.2; alfa = 0;
            int n = 2;
            for (int k = 0; k < 5; k++)
            {
                Koch(n, 1 / Math.Pow(3, n)/3, g);
                ObratLevo(360 / 5);
            }
            */

            //drevo
            int n = 5;
            Drevo(n, 0.5, 0, 90, 0.3, g);
        }
    }
}
