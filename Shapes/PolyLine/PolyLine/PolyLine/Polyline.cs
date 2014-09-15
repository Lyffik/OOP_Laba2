using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Shapedll;

namespace PolyLine
{
    public class Polyline:Shape
    {
        Polyline():base("PolyLine"){}
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(Pen,points.ToArray());
        }
    }
}
