using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Batman : IMilliardos , ISzuperhos
    {
        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }
        public double MekkoraAzEreje()
        {
            return this.lelemenyesseg*2;
        }
        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos.MekkoraAzEreje() < lelemenyesseg)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void KutyutKeszit()
        {
            lelemenyesseg = lelemenyesseg + 50;
        }
        public override string ToString()
        {
            return $"Batman: Leleményeség{this.lelemenyesseg}";
        }
    }
}
