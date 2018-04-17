using System;

namespace TP3
{
    class MainClass
    {
        static int cursor = 0;

        private static void Main(string[] args)
        {
            int[] tab = new int[5];
            save(1, tab);
            save(2, tab);
            Console.WriteLine("Dernière valeur sauvegardée : " + load(tab));
            for (int i = 0; i < 3; i++)
            {
                save(i, tab);
                Console.WriteLine(i);
                Console.WriteLine("Valeur sauvegardée pour i : " + load(tab));
            }
            Console.WriteLine();
            Point p = new Point(3, 4); // Créé un Point,
            p.sauv(); // sauvegarde sa valeur actuelle
            p.X = 5; // modifiez sa première coordonnée,
            Console.WriteLine(p); // affiche le point, 
            p.restaure(); // restaure sa version précédente,
            Console.WriteLine(p); // l'affiche. 

            Console.WriteLine();
            Disque d = new Disque(1, 2, 5); // Créé un Disque,
            d.sauv(); // sauvegarde sa valeur actuelle
            d.Centre = p; // modifiez sa première coordonnée,
            Console.WriteLine(d); // affiche le point, 
            d.restaure(); // restaure sa version précédente,
            Console.WriteLine(d); // l'affiche.
        }

        public static void save(int n, int[] t)
        {
            if (cursor >= t.Length)
                cursor = 0; // Ainsi, on ne stock que les 5 dernières valeur de la variable.
            t[cursor] = n;
            cursor++;
        }

        public static int load(int[] t)
        {
            return t[cursor - 1 % 5];
        }
    }

}
