using System.Drawing;
using Shapedll;

namespace PolyLine
{
    public class PolyLine : Shape
    {
        public PolyLine()
            : base("Polyggon")
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


        public void EditPoint(Point p)
        {
            points[1] = p;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(Pen, points.ToArray());
        }
    }
}