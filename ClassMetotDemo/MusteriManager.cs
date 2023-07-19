using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklenmiştir..." + musteri.MusteriAdi);

        }
        public void Sil(Musteri musteri)
        {

            Console.WriteLine("Silme işlemi başarıyla gerçekleşmilştir"+" : "+ musteri.MusteriSoyadi);



        }
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine("Listeleme işlemi başarıyla gerçekleşmiştir"+musteri.MusteriAdi + musteri.MusteriSoyadi +musteri.Id);

        
        }
        




    }
}
