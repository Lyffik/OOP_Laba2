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
        public override void AddPoint(Point p)
        {
                points.Add(p);
        }

        public override void EditLastPoint(Point p)
        {
            points[points.Count - 1] = p;
        }

        public override void EndDraw()
        {
            AddPoint(points[0]);
        }

        public void EditPoint(Point p)
        {
            points[1] = p;
        }
        public override void Draw(Graphics graphics)
        {
           graphics.DrawLines(Pen,points.ToArray());
        }
    }
}
