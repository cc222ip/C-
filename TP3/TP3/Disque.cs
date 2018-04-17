using System;
namespace TP3
{
    public class Disque : ICloneable
    {
        Point centre;
        int rayon;
        Disque hist;

        public Disque(int x, int y, int r) // Contructeur à 3 arguments entiers
        {
            centre = new Point(x, y);
            rayon = r;
        }

        public Disque(Point c, int r) // Contructeur à 2 arguments
        {
            centre = c;
            rayon = r;
        }

        public override string ToString()
        {
            return "(Centre : " + centre.ToString() + "; " + "Rayon : " + rayon.ToString() + ")";
        }

        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }

        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public void sauv()
        {
            hist = (TP3.Disque)this.Clone();
        }

        public void restaure()
        {
            centre = hist.Centre;
            rayon = hist.Rayon;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}