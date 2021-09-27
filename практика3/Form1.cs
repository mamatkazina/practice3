using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика3
{
    public partial class Form1 : Form
    {
        private Astro astroSun;
        private Astro astroMars;
        private Astro astroSaturn;
        private Astro astroComet;
        private Astro astroMoon;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            astroSun = new Sun();
            astroMars = new Mars();
            astroSaturn = new Saturn();
            astroComet = new Comet();
            astroMoon = new Moon();
        }

    


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Sun.Checked)
                astroSun.Draw(e.Graphics, Color.Yellow, 0.14*this.Width, 0.2*this.Height);
            else
                astroSun.Draw(e.Graphics, Color.Transparent, 0.14 * this.Width, 0.2 * this.Height);


            if (Mars.Checked)
                astroMars.Draw(e.Graphics, Color.OrangeRed, 0.59 * this.Width, 0.46 * this.Height);
            else
                astroMars.Draw(e.Graphics, Color.Transparent, 0.59 * this.Width, 0.46 * this.Height);


            if (Saturn.Checked)
                astroSaturn.Draw(e.Graphics, Color.Beige, 0.25 * this.Width, 0.62 * this.Height);
            else
                astroSaturn.Draw(e.Graphics, Color.Transparent, 0.25 * this.Width, 0.62 * this.Height);


            if (Comet.Checked)
                astroComet.Draw(e.Graphics, Color.DarkGray, 0.55 * this.Width, 0.11 * this.Height);
            else
                astroComet.Draw(e.Graphics, Color.Transparent, 0.55 * this.Width, 0.11 * this.Height);


            if (Moon.Checked)
                astroMoon.Draw(e.Graphics, Color.WhiteSmoke, 0.8 * this.Width, 0.31 * this.Height);
            else
                astroMoon.Draw(e.Graphics, Color.Transparent, 0.8 * this.Width, 0.31 * this.Height);



        }

        private void Sun_Click(object sender, EventArgs e)
        {  
            Sun.Checked = !Sun.Checked;
            this.Invalidate();
        }

        private void Mars_Click(object sender, EventArgs e)
        {
            Mars.Checked = !Mars.Checked;
            this.Invalidate();
        }

        private void Saturn_Click(object sender, EventArgs e)
        {
            Saturn.Checked = !Saturn.Checked;
            this.Invalidate();
        }

        private void Comet_Click(object sender, EventArgs e)
        {
            Comet.Checked = !Comet.Checked;
            this.Invalidate();
        }

        private void Moon_Click(object sender, EventArgs e)
        {
            Moon.Checked = !Moon.Checked;
            this.Invalidate();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
