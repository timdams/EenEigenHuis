using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Huis
    {
        private List<Kamer> kamers = new List<Kamer>();


        public void VoegKamerToe(Kamer kamerToeTeVoegen)
        {
            kamers.Add(kamerToeTeVoegen);
        }

        public int BerekenPrijs()
        {
            int prijs = 0;

            foreach (var kamer in kamers)
            {
                prijs += kamer.Prijs;
            }

            return prijs;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var kamer in kamers)
            {
                result += kamer.ToString()+ "\r\n";
            }

            return result;
        }
    }
}
