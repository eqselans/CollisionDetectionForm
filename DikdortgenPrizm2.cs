using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme6
{
    public class DikdortgenPrizm2 : GeometrikCisimler
    {// Kalıtım aldım ve Ciz metodunu cisme göre ezdim.
        public override void Ciz(Panel panel1)
        {
            Graphics graph = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2);

            Point[] points
                =
            {
                new Point(500,50),
                new Point(600,50),
                new Point(600,150),
                new Point(500,150)

            };

            graph.DrawPolygon(kalem, points);

            graph.DrawLine(kalem, 500, 50, 550, 25);
            graph.DrawLine(kalem, 550, 25, 650, 25);
            graph.DrawLine(kalem, 650, 25, 600, 50);

            graph.DrawLine(kalem, 650, 25, 650, 125);

            graph.DrawLine(kalem, 500, 150, 550, 125);
            graph.DrawLine(kalem, 550, 125, 650, 125);
            graph.DrawLine(kalem, 650, 125, 600, 150);
        }
    }
}
