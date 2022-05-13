using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class SlaapKamer: Kamer
    {
        //De prijs is de prijs van een gewone kamer * 2
        public SlaapKamer(int opper) : base(opper, "Slaapkamer")
        {

        }
        public override int Prijs
        {
            get
            {
                return base.Prijs * 2;
            }
        }
    }
}
