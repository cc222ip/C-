using System;
namespace tp2 {
    public class Button : GraphicalComponent {
        string id;
        static int c;

        public Button() { // Noir par défault
            actif = true;
            id = "Bt" + c;
            c++;
        }

        public Button(Color ccolor) {
            actif = true;
            myColor = ccolor;
            id = "Bt" + c;
            c++;
        }

        public override void affiche() {
            Console.WriteLine("Numéro d'identification du bouton : " + this.id);
            afficheColor();
        }

        public override void activer() {
            actif = true;
            Console.WriteLine("Exécution de l'action du bouton " + this.id);
        }
    }
}