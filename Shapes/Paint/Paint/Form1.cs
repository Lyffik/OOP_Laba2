﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Linedll;
using Shapedll;
using ShapeListdll;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Shape shape;
        private ShapesList shapeList=new ShapesList();
        private Dictionary<string, Type> shapes;
        private Boolean drawing = false;
        public Form1()
        {
            InitializeComponent();
            shapes = new Dictionary<string, Type>();
            string pluginsPath = Directory.GetCurrentDirectory() + "\\Plugins";
            string[] libraryFiles = Directory.GetFiles(pluginsPath, "*.dll", SearchOption.AllDirectories);
            foreach (var lib in libraryFiles)
            {
                Assembly asm = Assembly.LoadFile(lib);
                Type figure = asm.GetTypes().FirstOrDefault(x => x.IsSubclassOf(typeof(Shape)));
                if (figure != null)
                {
                    shapes.Add(figure.Name, figure);
                    ShapePicker.Items.Add(figure.Name);
                }
            }
            ShapePicker.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)           
            {
                shape.EditLastPoint(e.Location); 
                pictureBox.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            shapeList.DrawListOfShapes(e.Graphics);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                shape.EditLastPoint(e.Location);
                shape.EndDraw();
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                shape.AddPoint(e.Location);
            }
            else
            {
                shape = (Shape)Activator.CreateInstance(shapes[ShapePicker.SelectedItem.ToString()]);
                shapeList.AddShape(shape);
                shape.AddPoint(e.Location);
                shape.AddPoint(e.Location);
                drawing = true;
            }
        }
    }
}