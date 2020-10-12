using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class noveny
    {
        public string nev { get;private set; }
        public string resz { get;private set; }
        public int kezd { get;private set; }
        public int veg { get;private set; }
        public int tartam { get; private set; }
        


        public noveny(string sor)
        {
            string[] sed = sor.Split(';');
            this.nev = sed[0];
            this.resz = sed[1];
            this.kezd = int.Parse(sed[2]);
            this.veg = int.Parse(sed[3]);
            if (veg>kezd)
            {
                this.tartam = veg - kezd + 1;
            }
            else
            {
                this.tartam = 12 - kezd + veg + 1;
            }
        }
    }
}
