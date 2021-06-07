using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fractals
{
    class Tree
    {
        // Коментарий коментарий коментарий.
        public Point P1 { get; set; }
        // Коментарий коментарий коментарий.
        public Point P2 { get; set; }
        // Коментарий коментарий коментарий.
        public double Coefficient { get; set; }
        // Коментарий коментарий коментарий.
        public double Length { get; set; }
        // Коментарий коментарий коментарий.
        public double Angle { get; set; }
        // Коментарий коментарий коментарий.
        public double AngleLeft { get; set; }
        // Коментарий коментарий коментарий.
        public double AngleRight { get; set; }
        // Коментарий коментарий коментарий.
        public int Recursion { get; set; }
        // Коментарий коментарий коментарий.
        public Tree() { }
        // Коментарий коментарий коментарий.
        public Tree(double length, double coefficient, double angle, double angleLeft, double angleRight, int recursion, Point p1)
        {
            Length = length;
            Coefficient = coefficient;
            AngleLeft = angleLeft;
            AngleRight = angleRight;
            Angle = angle;
            Recursion = recursion;
            P1 = p1;
            P2 = new Point(p1.X-(int)(Length * Math.Cos(angle*Math.PI/180.0)), p1.Y-(int)(Length * Math.Sin(angle * Math.PI / 180.0)));
        }
        // Коментарий коментарий коментарий.
        public Tree VetkaLeft()
        {
            return new Tree(Length / Coefficient, Coefficient, AngleLeft, AngleLeft + AngleLeft -Angle, AngleLeft+ AngleRight-Angle, Recursion - 1, P2);
        }
        // Коментарий коментарий коментарий.
        public Tree VetkaRight()
        {
            return new Tree(Length / Coefficient, Coefficient, AngleRight, AngleRight + AngleLeft - Angle, AngleRight+ AngleRight - Angle, Recursion - 1, P2);
        }
    }
}
