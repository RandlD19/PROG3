using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_21_3
{
    public class Vozilo
    {
        private double gorivo;
        private double kapaciteta;
        private double poraba;
        private double PreostaliKilometri;
        private bool konstruktor = false;
        public Vozilo(double kapaciteta, double poraba)
        {
            NastaviGorivo(kapaciteta);
            NastaviKapaciteto(kapaciteta);
            NastaviPorabo(poraba);
            konstruktor = true;
            NastaviPreostaliKilometri();



        }

        //public double Gorivo
        //{
        //    get { return this.gorivo; }
        //    set
        //    { if (value < 0)
        //        {
        //            this.gorivo = 0;
        //        }
        //        else
        //        {
        //            this.gorivo = value;
        //        }

        //    }
        //}
        public void NastaviKapaciteto(double vrednsot)
        {
            if (vrednsot < 0)
            {
                throw new ArgumentException("Neveljavni vnos!");
            }
            else
            {
                this.kapaciteta = vrednsot;

            }
        }

        public void NastaviGorivo(double vrednsot)
        {
            if (vrednsot < 0)
            {
                throw new ArgumentException("Neveljavni vnos!");
            }
            else
            {
                this.gorivo = vrednsot;
                NastaviPreostaliKilometri();
            }
        }
        public void NastaviPorabo(double vrednsot)
        {
            if (vrednsot <= 0)
            {
                throw new ArgumentException("Neveljavni vnos!");
            }
            else
            {
                this.poraba = vrednsot;
                NastaviPreostaliKilometri();


            }
        }
        public void NastaviPreostaliKilometri()
        {
            if (konstruktor)
            {
                this.PreostaliKilometri = (this.gorivo / this.poraba) * 100;
            }

        }

        public void Crpalka()
        {
            NastaviGorivo(this.kapaciteta);
        }


        public bool pot(double[] tab)
        {
            double zacetno_gorivo = this.gorivo;
            
            foreach (double v in tab)
            {
                if (v < 0)
                {
                    NastaviGorivo(zacetno_gorivo);
                    throw new ArgumentException("Pot ne more biti negativna");
                }
                if (v == 0)
                {
                    if (this.gorivo == this.kapaciteta)
                    {
                        NastaviGorivo(zacetno_gorivo);
                        throw new ArgumentException("Ne moremo tankati pri polnem tanku");
                    }
                    else
                    {
                        Crpalka();
                    }
                }
                else
                {
                    try
                    {
                        NastaviGorivo(this.gorivo - (v * poraba) / 100);
                    }
                    catch
                    {
                        NastaviGorivo(zacetno_gorivo);
                        return false;
                    }

                }
            }
            return true;


           }
        public double Gorivo()
        {
            return this.gorivo;
        }
        public double Kapaciteta()
        {
            return this.kapaciteta;
        }
        public double Poraba()
        {
            return this.poraba;
        }

    }
}
