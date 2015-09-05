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
            for (int i = 0; i < 100; i++)
            {
                objectList.ForEach(x => move(x));
                Paint();
                System.Threading.Thread.Sleep(100);
            }
        }

        public void Paint()
        {
            graphicsObject.Clear(Color.Black);
            objectList.ForEach(x =>
            {
                graphicsObject.FillEllipse(Brushes.Red, x.getX(), x.getY(), x.getDiameter(), x.getDiameter());
            });
        }

        public void move(CelestialObject celObj)
        {
            celObj.setX(celObj.getX() + 1);
            celObj.setY(celObj.getY() + 1);
        }
    }
}