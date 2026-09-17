using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozlekedes
{
    class meteo : Utazas
    {
        public meteo(double alapdij, double tavolsag)
            : base(alapdij, tavolsag)
        {
        }
        public override double arSzamitas()
        {
            return alapdij * 2 + tavolsag * 50;
        }
    }
}
