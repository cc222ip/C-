namespace tp2 {
    public class Test {
        static public void Main(string[] args) {
            GraphicalComponent b1 = new Button(Color.Blue);
            //b1.affiche();
            GraphicalComponent b2 = new Button();
            //b2.affiche();
            b1.actif = false;
            GraphicalComponent m1 = new Menu();
            //m1.affiche();
            GraphicalComponent m2 = new Menu();
            GraphicalComponent m3 = new Menu();
            GraphicalComponent[] tab = new GraphicalComponent[] { b1, b2, m1, m2, m3 };
            foreach (GraphicalComponent elem in tab) {
                elem.affiche();
                elem.activer();
            }
        }
    }
}