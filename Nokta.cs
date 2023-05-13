using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme6
{
    public class Nokta : GeometrikCisimler
    {// Kalıtım aldım ve Ciz metodunu cisme göre ezdim.
        public override void Ciz(Panel panel1)
        {
            Graphics graph = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2);

            int x = 50;
            int y = 50;
            int boyut = 40;

            SolidBrush fırca = new SolidBrush(Color.Black);

            graph.FillEllipse(fırca, x - boyut / 2, y - boyut / 2, boyut, boyut);
            graph.DrawEllipse(kalem, x - boyut / 2, y - boyut / 2, boyut, boyut);
        }
    }
}
