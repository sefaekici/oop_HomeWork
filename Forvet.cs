

namespace Ödev_2
{
    class Forvet:Futbolcu
    {
        // class elemanları tanımlanmıştır.
        private double _Bitiricilik, _Ilk_Dokunus, _Kafa, _OzelYetenek;
        private double _Soguk_Kanlilik;
       //forvet elemanlarına değer atayan kurucu metod.
        public Forvet(string Ad_Soyad, int Forma_No)
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
            _Bitiricilik = random.Next(70, 100);
            _Ilk_Dokunus = random.Next(70, 100);
            _Kafa = random.Next(70, 100);
            _OzelYetenek = random.Next(70, 100);
            _Soguk_Kanlilik = random.Next(70, 100);

        }
        //Yüklenmiş pasver metodu pasın başarı şartını kontrol eder ve  bool değer döndürür.
        public override bool Pasver()
        {
            double Pas_Skor = Pas * 0.3 + Yetenek * 0.2 + _OzelYetenek * 0.2 + Dayaniklilik * 0.1 + Dogal_Form * 0.1 + Sans * 0.1;
            if (Pas_Skor > 60)
            {
                return true;
            }
            else
                return false;
        }
        //Yüklenmiş golvurusu metodu golun başarı şartını kontrol eder ve  bool değer döndürür.
        public override bool GolVurusu()
        {
            double Gol_Skor = Yetenek * 0.2 + _OzelYetenek * 0.2 + Sut * 0.1 + _Kafa * 0.1 + _Ilk_Dokunus * 0.1 + _Bitiricilik * 0.1 + _Soguk_Kanlilik * 0.1 + Kararlilik * 0.1 + Dogal_Form * 0.1 + Sans * 0.1;
            if (Gol_Skor > 70)
            {
                return true;

            }
            else
                return false;

        }
    }
}
