using System;

public class Point3D {
    private int[] point = new int[3];

    static public void Main(string[] args) {
        int x, y, z;
        string xx, yy, zz;
        bool again;
        do {
            Console.WriteLine("Entrez les coordonnées de votre point 3D :");
            Console.Write("x : ");
            xx = Console.ReadLine();
            Console.Write("y : ");
            yy = Console.ReadLine();
            Console.Write("z : ");
            zz = Console.ReadLine();

            again = !int.TryParse(xx,out x) | !int.TryParse(yy,out y) | !int.TryParse(zz,out z);
            if(again)
                Console.WriteLine("Il y a eu une erreur.");
        }
        while(again);

        Point3D p = new Point3D(x, y, z);
        Console.WriteLine("Affiche le premier point 3D avec la méthode 'toString()' :");
        Console.WriteLine(p.toString());
        Point3D pp = new Point3D(0, 0, 0);
        pp.affecter(p);
        Console.WriteLine("Affiche le point 3D affecté avec la méthode d'extension 'afficher()' :");
        pp.afficher();
    }

    public Point3D(int x, int y, int z) {
        this[0] = x;
        this[1] = y;
        this[2] = z;
    }

    public int this[int index] {
        get { return this.point[index]; }
        set { this.point[index] = value; }
    }

    public string toString() {
        return "[" + this[0] + ", " + this[1] + ", " + this[2] + "]";
    }

    public void affecter(Point3D p) {
        this[0] = p[0];
        this[1] = p[1];
        this[2] = p[2];
    }
}

public static class Extension {
    public static void afficher(this Point3D p) {
        Console.WriteLine(p.toString());
    }
}
