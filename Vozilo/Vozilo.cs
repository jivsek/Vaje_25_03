using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    public class Vozilo
    {
        private double gorivo;
        private double kapaciteta;
        private double poraba;


        public Vozilo(double kapaciteta, double poraba)
        {
            if (kapaciteta <= 0 || poraba <= 0)
            {
                throw new ArgumentException("Kapaciteta in poraba ne moreta biti manjša od 0");
            }

            this.kapaciteta = kapaciteta;
            this.gorivo = kapaciteta;       // Poln tank
            this.poraba = poraba;
        }

        public double PreostaliKilometri
        {
            get { return (gorivo / poraba) * 100; }
        }
        
        public void Crpalka()
        {
            gorivo = kapaciteta;
        }

        public bool LahkoPrevozi(double[] poti)
        {
            double zacasno_gorivo = gorivo;
            bool pravkar_napolnjeno = false;

            foreach (double pot in poti)
            {
                if (pot < 0)
                {
                    throw new ArgumentException("Pot ne mora biti negativna.");
                }

                if (pot == 0)
                {
                    if (pravkar_napolnjeno)
                    {
                        throw new ArgumentException("Dve zaporedni polnjenji.");
                    }

                    Crpalka();
                    pravkar_napolnjeno= true;
                    zacasno_gorivo = gorivo;
                    continue;
                }

                double porabljeno_gorivo = (pot / 100) * poraba;
                
                if (porabljeno_gorivo >  zacasno_gorivo)
                {
                    return false;
                }

                zacasno_gorivo -= porabljeno_gorivo;
                pravkar_napolnjeno = false;

            }

            gorivo = zacasno_gorivo;
            return true;
        }
    }
}
