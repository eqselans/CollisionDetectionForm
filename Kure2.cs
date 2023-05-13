using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme6
{
    public class Kure2:GeometrikCisimler
    {// Kalıtım aldım ve Ciz metodunu cisme göre ezdim.
        public override void Ciz(Panel panel1)
        {
            Graphics graph = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 2);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(500, 50, 100, 100);
            PathGradientBrush gradientBrush = new PathGradientBrush(path);
            gradientBrush.CenterPoint = new PointF(400, 400);
            gradientBrush.CenterColor = Color.White;
            gradientBrush.SurroundColors = new Color[] { Color.Gray };
            graph.FillEllipse(gradientBrush, 500, 50, 100, 100);
        }
    }
}
