using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme6
{
    public class DikdortgenPrizm : GeometrikCisimler
    {// Kalıtım aldım ve Ciz metodunu cisme göre ezdim.
        public override void Ciz(Panel panel1)
        {
            Graphics graph = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2);

            Point[] points
                =
            {
                new Point(50,50),
                new Point(150,50),
                new Point(150,150),
                new Point(50,150)

            };

            graph.DrawPolygon(kalem, points);

            graph.DrawLine(kalem, 50, 50, 100, 25);
            graph.DrawLine(kalem, 100, 25, 200, 25);
            graph.DrawLine(kalem, 200, 25, 150, 50);

            graph.DrawLine(kalem, 200, 25, 200, 125);

            graph.DrawLine(kalem, 50, 150, 100, 125);
            graph.DrawLine(kalem, 100, 125, 200, 125);
            graph.DrawLine(kalem, 200, 125, 150, 150);
        }
    }
}
