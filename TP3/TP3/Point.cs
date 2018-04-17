using System;

namespace TP3
{
    public class Point
    {
        int x, y; // Coordonnées entières
        Point hist;

        public Point() // Constructeur sans argument
        {
            x = 0;
            y = 0;
        }

        public Point(int xx, int yy) // Constructeur à 2 arguments entiers
        {
            x = xx;
            y = yy;
        }

        public override string ToString()
        {
            return "(" + x.ToString() + "; " + y.ToString() + ")";
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void sauv() {
            //hist = this;
            hist = (TP3.Point)MemberwiseClone();
        }

        public void restaure() {
            x = hist.X;
            y = hist.Y;
        }
    }
}

