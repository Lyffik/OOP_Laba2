using System.Collections.Generic;
using System.Drawing;

namespace Shapedll
{
    public abstract class Shape
    {
        protected List<Point> points;

        protected Shape(string name)
        {
            Pen = new Pen(Color.Black);
            ShapeName = name;
            points = new List<Point>();
        }

        public virtual void AddPoint(Point p)
        { }

        public Pen Pen { get; set; }

        public string ShapeName { get; set; }

        public abstract void Draw( Graphics graphics);
    }
}