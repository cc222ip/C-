using System;
namespace tp2 {
    public class Menu : GraphicalComponent {
        public string id;
        public static int c;

        public Menu() {
            myColor = Color.Blue;
            id = "Mn" + c;
            c++;
        }

        public override void affiche() {
            Console.WriteLine("Numéro d'identification du menu : " + this.id);
        }
    }
}