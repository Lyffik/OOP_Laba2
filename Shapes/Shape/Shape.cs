using System.Collections.Generic;
using System.Drawing;

namespace Shapedll
{
    public abstract class Shape
    {
        protected List<Point> points;

        protected Shape(string name)
        {
            Pen = new Pen(Color.Blue, 2);
            ShapeName = name;
            points = new List<Point>();
        }

        public Pen Pen { get; set; }

        public string ShapeName { get; set; }

        public virtual void EndDraw()
        {
        }

        public virtual void AddPoint(Point p)
        {
        }

        public virtual void EditLastPoint(Point p)
        {
        }

        public abstract void Draw(Graphics graphics);
    }
}