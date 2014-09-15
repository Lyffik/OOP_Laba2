using System.Collections.Generic;
using System.Drawing;

namespace Shapedll
{
    public abstract class Shape
    {
        protected List<Point> points=new List<Point>();

        protected Shape(string name)
        {
            Pen = new Pen(Color.Black);
            ShapeName = name;
        }

        public virtual void AddPoint(Point p)
        { }

        public Pen Pen { get; set; }

        public string ShapeName { get; set; }

        public abstract void Draw( Graphics graphics);
    }
}