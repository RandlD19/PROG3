using System;
namespace Naloge_z_izpitov_P3_OOP
{
    public class Polonica
    {
        private int _Starost;
        private int _SteviloPik;

        public Polonica(int starost, int steviloVidnihpik)
        {
            this.Starost = starost;
            this.SteviloPik = steviloVidnihpik;
        }

        public int Starost
        {
            get { return _Starost; }
            set
            {

                if (value > 200)
                {
                    throw new Exception("Pikapolonice ne morejo biti stare več kot 4 leta.");
                }
                if (value < 0)
                {
                    throw new Exception("Število tednov mora biti nenegativno število.");
                }
                _Starost = value;
            }
        }

        public int SteviloPik
        {
            get { return _SteviloPik; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Število pik mora biti nenegativno število.");
                }
                if (value > 7)
                {
                    throw new Exception("Število pik je lahko največ 7!");
                }
                if (this.Starost < 100 && value < 7)
                {
                    throw new Exception("Na začetku imajo vse pikapolonice 7 pik!.");
                }
                _SteviloPik = value;
            }
        }

        public override string ToString()
        {
            return $"Jaz sem PikaPoka, stara {this.Starost} tednov in imam {this.SteviloPik} pik.";
        }

        public static Polonica[] operator *(Polonica polonica1, int stevilo)
        {
            Polonica[] tab = new Polonica[stevilo];
            for (int i = 0; i < stevilo; i++)
            {
                tab[i] = polonica1;
            }
            return tab;
        }

        public static Polonica[] operator *(int stevilo, Polonica polonica1)
        {
            Polonica[] tab = new Polonica[stevilo];
            for (int i = 0; i < stevilo; i++)
            {
                tab[i] = polonica1;
            }
            return tab;
        }

        public static int steviloPik(Polonica[] pikapolonice)
        {
            int vsota = 0;
            foreach (Polonica polonica in pikapolonice)
            {
                if (polonica.Starost > 52)
                {
                    vsota += polonica.SteviloPik;
                }
            }
            return vsota;
        }

    }

}
