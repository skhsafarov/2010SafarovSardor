using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    // Пожалей чел!
    // Если че кометы есть.))
    public partial class Form1 : Form
    {
        // Коментарий коментарий коментарий.
        public Form1()
        {
            InitializeComponent();
        }
        // Коментарий коментарий коментарий.
        void Fractal(PointF p1, PointF p2, PointF p3, int n, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            if (n == int.Parse(RecursionDepth.Text))
            {
                gr.DrawLine(new Pen(Color.Red), p1, p2);
                gr.DrawLine(new Pen(Color.Red), p2, p3);
                gr.DrawLine(new Pen(Color.Red), p3, p1);

                Fractal(p1, p2, p3, n - 1, e);
                Fractal(p2, p3, p1, n - 1, e);
                Fractal(p3, p1, p2, n - 1, e);
            }
            else if (n > 0)
            {
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);

                gr.DrawLine(new Pen(Color.Red), p4, pn);
                gr.DrawLine(new Pen(Color.Red), p5, pn);
                gr.DrawLine(new Pen(Color.Red), p4, p5);

                Fractal(p4, pn, p5, n - 1,e);
                Fractal(pn, p5, p4, n - 1,e);
                Fractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3,
                    (2 * p1.Y + p3.Y) / 3), n - 1,e);
                Fractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3,
                    (2 * p2.Y + p3.Y) / 3), n - 1, e);

            }
        }
        // Коментарий коментарий коментарий.
        private void DrowTree(double a, double b, double c, double d, int f, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var list = new List<Tree>[] { new List<Tree>(), new List<Tree>() };
            var tree = new Tree(a, b, 90, c, d, f, new Point(Display.Width / 2, Display.Height));
            list[0].Add(tree);
            var a1 = list[0][0].Recursion;
            g.DrawLine(new Pen(Color.Red), list[0][0].P1, list[0][0].P2);
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < list[i % 2].Count; j++)
                {
                    var b1 = list[i % 2][j].VetkaLeft();
                    var c1 = list[i % 2][j].VetkaRight();
                    g.DrawLine(new Pen(Color.Red), b1.P1, b1.P2);
                    g.DrawLine(new Pen(Color.Red), c1.P1, c1.P2);
                    list[(i + 1) % 2].Add(b1);
                    list[(i + 1) % 2].Add(c1);
                }
                list[i % 2].Clear();
            }
        }
        // Коментарий коментарий коментарий.
        private void Display_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (Menu.SelectedTab.Name == "FractalTree")
            {
                if (double.TryParse(LengthTree.Text, out double a) && double.TryParse(CoefficientTree.Text, out double b) && double.TryParse(AngleLeftTree.Text, out double c) && double.TryParse(AngleRightTree.Text, out double d) && int.TryParse(RecursionDepth.Text, out int f))
                {
                    DrowTree(a, b, c, d, f, e);
                }
                else
                {
                    this.Display.Paint -= new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
                    MessageBox.Show("введите число!");
                }
            }
            if (Menu.SelectedTab.Name == "KochCurve")
            {
                float w = Display.Width;
                float h = Display.Height;
                Fractal(new PointF(w / 2, h / 5),
                    new PointF((float)(w / 2 - 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5),
                    new PointF((float)(w / 2 + 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5),
                    int.Parse(RecursionDepth.Text), e);
            }
        }
        // Коментарий коментарий коментарий.
        private void Start_Click(object sender, EventArgs e)
        {
            this.Display.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            Refresh();
        }
        // Коментарий коментарий коментарий.
        private void Display_Resize(object sender, EventArgs e)
        {
            Refresh();
            return;
        }
    }
}