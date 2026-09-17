using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozlekedes
{
    class eroller : Utazas
    {
        public eroller(double alapdij, double tavolsag)
            : base(alapdij, tavolsag)
        { 
        }

        public override double arSzamitas()
        {
            return tavolsag * 120;
        }
    }
}
