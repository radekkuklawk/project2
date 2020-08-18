using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class Suv : Car
    {
        public int Passengers { get; }

        public Suv() : base ()
        {
            Passengers = 0;
        }

        public Suv(string SUVMake, int SUVModel, int SUVKM,double SUVPrice, int SUVPassengers) : base(SUVMake, SUVModel, SUVKM, SUVPrice)
        { 
            this.Passengers = SUVPassengers; 
        }
}
}
