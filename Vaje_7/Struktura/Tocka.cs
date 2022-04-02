using System;
namespace Struktura
{
    public struct Tocka
    {
        public double x { get; set; }
        public double y { get; set; }

        public Tocka(double x, double y)
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
