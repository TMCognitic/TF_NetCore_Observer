using ObserverPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class Produit : Subject
    {
        private double _prix;

        public string Nom { get; init; }
        public double Prix
        {
            get
            {
                return _prix;
            }

            set
            {
                if(_prix != value)
                {
                    _prix = value;
                    Notify();
                }
            }
        }

        public Produit(string nom) 
        {
            Nom = nom;
        }

    }
}
