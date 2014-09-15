using System;
using System.Drawing;
using Shapedll;

namespace Rectdll
{
    public class Rect : Shape
    {
        public Rect() : base("Rectangle")
        {
        }

        public override void Draw(Graphics graphics)
        {
            int x, y, width, heigth;
            if (points[0].X <= points[1].X)
            {
                x = points[0].X;
            }
            else
            {
                x = points[1].X;
            }
            if (points[0].Y <= points[1].Y)
            {
                y = points[0].Y;
            }
            else
            {
                y = points[1].Y;
            }
            width = Math.Abs(points[0].X - points[1].X);
            heigth = Math.Abs(points[0].Y - points[1].Y);
            var rectangle = new Rectangle(x, y, width, heigth);
        }
    }
}