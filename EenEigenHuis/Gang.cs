using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Gang : Kamer
    {

        public Gang(int opper) : base(opper, "Gang")
        {
        }

        public override int Prijs
        {
            get
            {
                return 10 * Oppervlakte;
            }
        }
    }
}
