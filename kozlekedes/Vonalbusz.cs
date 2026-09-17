using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozlekedes
{
    class Vonalbusz : Utazas
    {
        public Vonalbusz(double alapdij, double tavolsag)
            : base(alapdij, tavolsag)
        {
        }

        public override double arSzamitas()
        {
            return alapdij + tavolsag * 30;
        }
    }
}
