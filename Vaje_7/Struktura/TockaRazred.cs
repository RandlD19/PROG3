using System;
namespace Struktura
{
    public class TockaRazred
    {
        public double x { get; set; }
        public double y { get; set; }

        public TockaRazred(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x: {this.x}, y: {this.y}";
        }
    }
}
