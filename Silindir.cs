using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme6
{
    public class Silindir:GeometrikCisimler
    {// Kalıtım aldım ve Ciz metodunu cisme göre ezdim.
        public override void Ciz(Panel panel1)
        {
            Graphics graph = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2);

            graph.DrawEllipse(kalem, 50, 150, 100, 50);

            graph.DrawLine(kalem, 50, 175, 50, 75);
            graph.DrawLine(kalem, 150, 175, 150, 75);

            graph.DrawEllipse(kalem, 50, 50, 100, 50);
        }
    }
}
