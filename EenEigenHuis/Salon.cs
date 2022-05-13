using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EenEigenHuis
{
    class Salon: Kamer
    {
        public Salon(bool schouwNodig) : base(20, "Salon")
        {
            HeeftSchouw = schouwNodig;
        }
        public bool HeeftSchouw { get; private set; }
        public override int Prijs
        {
            get
            {
                if (HeeftSchouw) return 500;

                return 300;
            }
        }
    }
}
