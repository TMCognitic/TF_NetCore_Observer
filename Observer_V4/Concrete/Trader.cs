using ObserverPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class Trader
    {
        public string Nom { get; init; }

        public Trader(string nom)
        {
            Nom = nom;
        }

        public void Reagir(ISubject subject)
        {
            Produit? produit = subject as Produit;

            if (produit is null)
                return;

            Console.WriteLine($"{Nom} est notifié du changement de prix du produit '{produit.Nom}' : {produit.Prix}");
        }
    }
}
