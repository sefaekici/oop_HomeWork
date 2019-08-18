using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_2
{
    class Defans:Futbolcu
    {
        //defans sınıfı için gerekli elamanlar tanımlanmıştır.
        private double _Pozisyon_Alma, _Kafa, _Sicrama;
       
        //defans elamanlarına değer atayan kurucu fonksiyon.
        public Defans(string Ad_Soyad, int Forma_No)
        {
            this.Ad_Soyad = Ad_Soyad;
            this.Forma_No = Forma_No;
            Hiz = random.Next(50, 100);
            Dayaniklilik = random.Next(50, 100);
            Pas = random.Next(50, 100);
            Sut = random.Next(50, 100);
            Yetenek = random.Next(50, 100);
            Kararlilik = random.Next(50, 100);
            Dogal_Form = random.Next(50, 100);
            Sans = random.Next(50, 100);
            _Pozisyon_Alma = random.Next(50, 90);
            _Kafa = random.Next(50, 90);
            _Sicrama = random.Next(50, 90);
        }

        //Yüklenmiş pasver metodu pasın başarı şartını kontrol eder ve bool değer döndürür.
        public override bool Pasver()
        {
            double Pas_Skor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + Dogal_Form * 0.1 + Sans * 0.2;
            if (Pas_Skor > 60)
            {
                return true;
            }
            else
                return false;
        }

        //yuklenmiş golvurusu metodu golün başarı şartını kontrol eder ve bool değer döndürür.
        public override bool GolVurusu()
        {
            double Gol_Skor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + Dogal_Form * 0.1 + _Sicrama*0.1 + Sans * 0.1;
            if (Gol_Skor > 70)
            {
                return true;

            }
            else
                return false;

        }
    }
}
