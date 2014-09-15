using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapedll;

namespace ShapeListdll
{
    public class ShapesList
    {
        private List<Shape> shapes = new List<Shape>();

        public int Count()
        {
            return shapes.Count;
        }
        public void AddShape(Shape sh)
        {
            shapes.Add(sh);
        }

        public void DrawListOfShapes(Graphics graphics)
        {
            foreach (Shape sh in shapes)
            {
                sh.Draw(graphics);
            }
        }

    }
}
