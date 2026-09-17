using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozlekedes
{
    abstract class Utazas
    {
        protected double alapdij;
        protected double tavolsag;

        public Utazas(double alapdij, double tavolsag)
        {
            this.alapdij = alapdij;
            this.tavolsag = tavolsag;
        }

        public abstract double arSzamitas();
    }

    internal class utazas
    {
    }
}
