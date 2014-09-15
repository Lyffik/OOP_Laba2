using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapedll;
namespace Linedll
{
    public class Line : Shape
    {
        public Line(): base("Line")
        {}

        public override void AddPoint(Point p)
        {
            if (points.Count<2)
            {
                points.Add(p);
            }
            else
            {
                EditPoint(p);
            }
          
        }

        public void EditPoint(Point p)
        {
            points[1] = p;
        }

        public override void Draw(Graphics graphics)
        {
                graphics.DrawLine(Pen,points[0],points[1]);      
        }
    }
}
