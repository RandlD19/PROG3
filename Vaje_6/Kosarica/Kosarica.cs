using System;
namespace Razredi
{

    public class Kosarica
    {
        private dynamic objekt;

        public dynamic Objekt
        {
            get { return objekt; }
            set { objekt = value; }
        }

        public override string ToString()
        {
            return this.Objekt.ToString();
        }

    }
}
