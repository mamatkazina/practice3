using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика3
{
    abstract class Astro
    {
        protected int radius;
        protected Point position;
        protected Form1 form;

        public abstract void Draw(Graphics graf, Color color, double X, double Y);

    }

    class Sun: Astro
    {
        public Sun() 
        {
            this.radius = 50;
           
        }

        public override void Draw(Graphics graf, Color color, double X, double Y)
        {
          graf.FillEllipse(new SolidBrush(color), (float)X, (float)Y, 2*radius, 2*radius);
        }
    }

    class Mars : Astro
    {
        private Color MarsCraters;
        public Mars() : base()
        {
            radius = 36;
            MarsCraters = Color.DarkRed;
        }

        public override void Draw(Graphics graf, Color color, double X, double Y)
        {
            graf.FillEllipse(new SolidBrush(color), (float)X, (float)Y, 2 * radius, 2 * radius);
            if (color != Color.Transparent)
            {
                graf.FillEllipse(new SolidBrush(MarsCraters), (float)X + 20, (float)Y + 12, 18, 18);
                graf.FillEllipse(new SolidBrush(MarsCraters), (float)X + 36, (float)Y + 34, 26, 26);
                graf.FillEllipse(new SolidBrush(MarsCraters), (float)X + 15, (float)Y + 40, 10, 10);
            }
        }
    }

    class Saturn : Astro
    {
        private Color SaturnLine;
        public Saturn() : base()
        {
            radius = 45;
  
            SaturnLine = Color.Red;
        }


        public override void Draw(Graphics graf, Color color, double X, double Y)
        {
            graf.FillEllipse(new SolidBrush(color), (float)X, (float)Y, 2 * radius, 2 * radius);
            if (color != Color.Transparent)
            {
                graf.FillPie(new SolidBrush(SaturnLine), (float)X-5, (float)Y+29, 140, 25, -18, 180);
                graf.FillPie(new SolidBrush(SaturnLine), (float)X-35, (float)Y+29, 140, 25, 18, 180);
            }
        }
    }

    class Comet : Astro
    {
        private Color CometLine;
        public Comet() : base()
        {
            radius = 22;
            position = new Point(370, 50);
            CometLine = Color.Red;
        }


        public override void Draw(Graphics graf, Color color, double X, double Y)
        {
            graf.FillEllipse(new SolidBrush(color), (float)X, (float)Y, 2 * radius, 2 * radius);
            if (color != Color.Transparent)
            {

                //graf.DrawLine(CometLine, 370, 80, 360, 120);
                graf.FillEllipse(new SolidBrush(CometLine), (float)X, (float)Y+35, 6, 50);
                graf.FillEllipse(new SolidBrush(CometLine), (float)X+10, (float)Y + 25, 6, 50);       
                graf.FillEllipse(new SolidBrush(CometLine), (float)X+20, (float)Y + 35, 6, 50);
                graf.FillEllipse(new SolidBrush(CometLine), (float)X+25, (float)Y + 35, 6, 50);        
                graf.FillEllipse(new SolidBrush(CometLine), (float)X+36, (float)Y + 35, 6, 40);
            }
        }
    }

    class Moon : Astro
    {
        private Color MoonCraters;
        public Moon() : base()
        {
            radius = 30;
            position = new Point(540, 140);
            MoonCraters = Color.Brown;
        }


        public override void Draw(Graphics graf, Color color, double X, double Y)
        {
            graf.FillEllipse(new SolidBrush(color), (float)X, (float)Y, 2 * radius, 2 * radius);
            if (color != Color.Transparent)
            {
                graf.FillEllipse(new SolidBrush(MoonCraters), (float)X + 6, (float)Y + 18, 18, 18);
                graf.FillEllipse(new SolidBrush(MoonCraters), (float)X + 32, (float)Y + 32, 21, 21);
                graf.FillEllipse(new SolidBrush(MoonCraters), (float)X + 35, (float)Y + 7, 10, 10);
            }
        }
    }
}
