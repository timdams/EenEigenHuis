using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Kamer
    {
        public Kamer(int opp, string naam)
        {
            Oppervlakte = opp;
            Naam = naam;
        }
        public int Oppervlakte { get; set; }
        public string Naam { get; set; } = "Kamer";
        public virtual int Prijs { get; } = 400;

        public override string ToString()
        {
            return $"{Naam} + {Prijs}";
        }
    }
}
