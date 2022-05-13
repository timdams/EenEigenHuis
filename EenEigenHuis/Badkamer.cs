using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Badkamer: Kamer
    {
        public Badkamer(): base(10,"Badkamer")
        {

        }
        public override int Prijs
        {
            get
            {
                return 500;
            }
        }
    }
}
