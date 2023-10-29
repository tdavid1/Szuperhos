using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    internal class Vasember : Bosszuallo, IMilliardos
    {
        public Vasember(double szuperero, bool vanEGyengesege) : base(szuperero, vanEGyengesege)
        {
            szuperero = 150;
            vanEGyengesege = true;
        }
        public void KutyutKeszit()
        {
            Random r = new Random();
            Szuperero = Szuperero + r.Next(0,11);
        }
        public override bool MegmentiAVilagot()
        {
            if(Szuperero > 1000)
            {
                return true;
            }
            else { 
                return false; 
            }  
        }
        public override string ToString()
        {
            return "Vasember"+base.ToString();
        }
    }
}
