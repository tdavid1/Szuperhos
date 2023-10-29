using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        public Vasember()
        {
            Szuperero = 150;
            VanEGyengesege = true;
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
