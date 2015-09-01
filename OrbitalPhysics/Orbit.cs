using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OrbitalPhysics
{
    class Orbit
    {
        public static Form form = new Form();
        public static System.Drawing.Graphics graphicsObject = form.CreateGraphics();
        public static List<CelestialObject> objectList = new List<CelestialObject>();

        public void start()
        {
            form.BackColor.Equals(Color.Black);
            form.Size.Equals(new Size(1000, 800));
            form.Show();

            objectList.Add(new CelestialObject(10, 10, 100, 50, 100));
            objectList.Add(new CelestialObject(10, 10, 200, 305, 100));
            foreach (CelestialObject celObject in objectList)
            {
                Paint(celObject.getDiameter(), celObject.getX(), celObject.getY());
            }
            System.Threading.Thread.Sleep(5000);
        }

        public void Paint(float diameter, float xpos, float ypos)
        {
            graphicsObject.FillEllipse(Brushes.Red, xpos, ypos, diameter, diameter);
        }
    }
}