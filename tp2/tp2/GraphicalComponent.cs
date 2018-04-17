using System;
namespace tp2 {
    public enum Color { Black = 0, Red, Blue, Green, Purple, Orange, Grey };
    public class GraphicalComponent {
        public bool actif;
        protected Color myColor = new Color();

        public Color ComponentColor { // moyen de définir et de retrouver la couleur d’un composant.
            get;
            set;
        }

        public virtual void  affiche() {
            
        }

        public void afficheColor() {
            Console.WriteLine("La couleur du composant est " + myColor);
        }

        public virtual void activer() {
            actif = true;
        }
    }
}