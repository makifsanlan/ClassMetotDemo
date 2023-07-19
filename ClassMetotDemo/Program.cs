using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
           
            musteri1.MusteriAdi = "Faruk";
            musteri1.MusteriSoyadi = "Yanık";
            musteri1.Id = 12313;

            Musteri musteri2 = new Musteri();

            musteri2.MusteriAdi = "M.Akif";
            musteri2.MusteriSoyadi = "Sanlan";
            musteri2.Id = 23424;
            MusteriManager mstr = new MusteriManager();
            mstr.Ekle(musteri1);
            mstr.Sil(musteri2);
            mstr.Listele(musteri1);
            mstr.Listele(musteri2);

            Console.ReadLine();



        }
    }
}
