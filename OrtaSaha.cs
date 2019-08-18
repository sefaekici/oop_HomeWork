

namespace Ödev_2
{
    class OrtaSaha:Futbolcu
    {
        //orta saha sınıfı elamanları tanımlanmıştır.
        private double _Uzun_Top, _Ilk_Dokunus, _Uretkenlik, _TopSurme;
        private double _Ozel_Yetenek;
        
        //orta saha elemanlarına değer atayan kurucu metot.
        public OrtaSaha(string Ad_Soyad, int Forma_No)
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
            _Uzun_Top = random.Next(60, 100);
            _Ilk_Dokunus = random.Next(60, 100);
            _Uretkenlik = random.Next(60, 100);
            _TopSurme = random.Next(60, 100);
            _Ozel_Yetenek = random.Next(60, 100);
        }
        //Yüklenmiş pasver metodu pasın başarı şartını kontrol eder ve  bool değer döndürür.
        public override bool Pasver()
        {
            double Pas_Skor = Pas * 0.3 + Yetenek * 0.2 + _Ozel_Yetenek * 0.2+Dayaniklilik * 0.1+ Dogal_Form * 0.1 + _Uzun_Top * 0.1 + _TopSurme * 0.1 + Sans * 0.1;
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
            double Gol_Skor = Yetenek * 0.3 + _Ozel_Yetenek * 0.2 + Sut * 0.2 + _Ilk_Dokunus * 0.1 + Kararlilik * 0.1 + Dogal_Form * 0.1 + Sans * 0.1;
            if (Gol_Skor > 70)
            {
                return true;

            }
            else
                return false;

        }
    }
}
