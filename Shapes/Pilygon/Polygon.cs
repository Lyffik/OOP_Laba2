using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapedll;

namespace Pilygondll
{
    public class Polygon : Shape
    {
        public Polygon () : base("Polygon")
        {
        }

        public override void Draw(Graphics graphics)
        {
           graphics.DrawPolygon(Pen,points.ToArray());
        }
    }
}
