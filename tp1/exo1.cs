using System;

public class PileDEntiers {
    private int[] pile;
    private int position;

    static public void Main(string[] args) {
        PileDEntiers p = new PileDEntiers();
        try {
            p.empile(4);
            p.empile(5);
            p.empile(8);
            Console.WriteLine("Il y a " + p.NbEntiers + " entiers dans la pile :");
            p.affiche();
            Console.WriteLine("On dépile " + p.depile() + ":");
            p.affiche();
            Console.WriteLine("Il reste " + p.NbEntiers + " entiers dans la pile.");
            Console.WriteLine("On ajoute 2 à chaque entier de la pile :");
            PileDEntiers p_modifie = p + 2;
            p_modifie.affiche();
        }
        catch (Exception e) {
            System.Console.WriteLine(e.Message);
        }
    }

    public PileDEntiers(int taille = 20) {
        this.position = taille - 1;
        this.pile = new int[taille];
    }

    public void empile(int p) {
        if(this.pleine())
            throw new Exception("La pile est déjà pleine.");
        pile[position--] = p;
    }

    public int depile() {
        if(this.vide())
            throw new Exception("La pile est vide.");
        return pile[++position];
    }

    public bool pleine() {
        return position == -1;
    }

    public bool vide() {
        return position == pile.Length - 1;
    }

    public void affiche() {
        if(this.vide())
            throw new Exception("La pile est vide.");
        for(int i = position + 1; i < pile.Length; i++)
            Console.Write(pile[i] + " - ");
        Console.WriteLine();
    }

    public int NbEntiers { // Propriété
        get { return 19 - position; }
    }

    public void incrementeN(int n) {
        if(this.vide())
            throw new Exception("La pile est vide.");
        for(int i = position + 1; i < pile.Length; i++)
            pile[i] += n;
    }

    public static PileDEntiers operator +(PileDEntiers p, int n) { // Opérateur
        for(int i = p.position + 1; i < p.pile.Length; i++)
            p.pile[i] += n;
        return p;
    }
}
