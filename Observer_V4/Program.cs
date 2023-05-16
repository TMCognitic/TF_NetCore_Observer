using ObserverPattern.Concrete;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produit produit = new Produit("NASDAQ")
            {
                Prix = 13_340.17
            };

            Produit produit2 = new Produit("BEL20")
            {
                Prix = 3_744.95
            };

            Trader koumeil = new Trader("Koumeil");
            Trader elody = new Trader("Elody");

            produit.Handler += koumeil.Reagir;
            produit.Handler += elody.Reagir;

            produit.Prix = 13_341.19;
        }
    }
}