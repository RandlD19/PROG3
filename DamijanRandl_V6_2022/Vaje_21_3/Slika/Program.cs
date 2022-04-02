using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tu naloži sliko
            string path = @"C:\Users\Uporabnik\Downloads\Bitmap-20220321\Bitmap\";
            Bitmap slika = new Bitmap(@"C:\Users\Uporabnik\Downloads\Bitmap-20220321\Bitmap\slika.jpg", true);
            //naredi kopijo slike
            Bitmap kopija = (Bitmap)slika.Clone();
            //spremeni kopijo z metodo obrezi_in_obrni
            Bitmap kopija2 = obrezi_in_obrni(kopija);
            kopija2.Save(path + "zdisemija.jpg");
            //shrani kopijo slike
        }
        static Bitmap obrezi_in_obrni(Bitmap slika)
        {
            Rectangle rec = new Rectangle(0, 0, 800, 800);
            //funkcija naj obreže sliko na 800x800
            if (slika.Width < 800 || slika.Height < 800)
            {
                Console.WriteLine("Slika je premajhna");
                return null;
            }
            Bitmap obrezano = slika.Clone(rec, slika.PixelFormat);
            //če je slika premajhna naj vrne izpis "Slika je premajhna" in naj funkcija vrne null
            //sliko se obrni za 270 stopinj in zrcali čez Y os
            obrezano.RotateFlip(RotateFlipType.Rotate270FlipY);

            return obrezano;
        }
    }
}

