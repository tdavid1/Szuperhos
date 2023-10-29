using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public abstract bool MegmentiAVilagot();

        public double MekkoraAzEreje()
        {
            return this.szuperero;
        }
        public bool LegyoziE(ISzuperhos szuperhos)
        {
            return true;
        }
        public override string ToString()
        {
            if (vanEGyengesege == true)
            {
                return $"Szupererő:{this.szuperero}; Van Gyengesége";
            }
            else
            {
                return $"Szupererő:{this.szuperero}; Nincs Gyengesége";
            }
        }
    }
}