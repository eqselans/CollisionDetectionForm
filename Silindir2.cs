using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme6
{
    public class Silindir2:GeometrikCisimler
    {// Kalıtım aldım ve Ciz metodunu cisme göre ezdim.
        public override void Ciz(Panel panel1)
        {
            Graphics graph = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2);

            graph.DrawEllipse(kalem, 500, 150, 100, 50);

            graph.DrawLine(kalem, 500, 175, 500, 75);
            graph.DrawLine(kalem, 600, 175, 600, 75);

            graph.DrawEllipse(kalem, 500, 50, 100, 50);
        }
    }
}
