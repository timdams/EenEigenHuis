using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class DeluxeSlaapkamer: SlaapKamer
    {
        //Prijs van een deluxeslaapkamer is de prijs van een slaapkamer +10%

        public DeluxeSlaapkamer():base(500)
        {
            Naam= "iSlaapKamer";
        }

        public override int Prijs
        {
            get
            {
   

                return base.Prijs + (int)(base.Prijs * 0.1);
            }
        }
    }
}
