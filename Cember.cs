using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme6
{
    public class Cember : GeometrikCisimler
    {   // Kalıtım aldım ve Ciz metodunu cisme göre ezdim.
        public override void Ciz(Panel panel1)
        {   
            Graphics graph = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2);

            graph.DrawEllipse(kalem, 50, 50, 100, 100);
        }
    }
}
