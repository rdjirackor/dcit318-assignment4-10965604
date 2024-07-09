using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool drawing = false;
        private Point startPoint, endPoint;
        private List<Tuple<Point, Point>> lines = new List<Tuple<Point, Point>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                startPoint = e.Location;
            }
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                endPoint = e.Location;
                canvasPanel.Invalidate();
            }
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = false;
                lines.Add(new Tuple<Point, Point>(startPoint, endPoint));
            }
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (var line in lines)
            {
                e.Graphics.DrawLine(Pens.Black, line.Item1, line.Item2);
            }

            if (drawing)
            {
                e.Graphics.DrawLine(Pens.Red, startPoint, endPoint);
            }
        }
    }
}
