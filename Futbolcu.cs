using System;


namespace Ödev_2
{
    class Futbolcu
    {
        //random değer üretmeye yarayan random sınıfı.
        public Random random = new Random();
        //futbolcu sınıfı elamanları tanımlanmıştır.
        protected string Ad_Soyad;
        protected int Forma_No;
        protected double Hiz, Dayaniklilik, Pas, Sut, Yetenek, Kararlilik;
        protected double Dogal_Form, Sans;

        
        
        public Futbolcu(string Ad_Soyad,int Forma_No) //Futbolcu elemanlarına değer atayan kurucu metot.
        {
            this.Ad_Soyad = Ad_Soyad;
            this.Forma_No = Forma_No;
            Hiz = random.Next(50,100);
            Dayaniklilik = random.Next(50,100);
            Pas = random.Next(50,100);
            Sut = random.Next(50,100);
            Yetenek = random.Next(50,100);
            Kararlilik = random.Next(50,100);
            Dogal_Form = random.Next(50,100);
            Sans = random.Next(50,100);
        }
        //Olmayınca hata veriyor ben de çözemedim hocam :)
        public Futbolcu()
        {

        }
        //yüklencek pasver metodu pas başarı durumunu kontrol eden ve bool değer döndüren metot.
        public virtual bool Pasver()
        {
            double Pas_Skor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + Dogal_Form * 0.1 +Sans * 0.2;
            if (Pas_Skor > 60)
            {
                return true;
            }
            else
                return false;
        }
        //Gol başarı durumunu kontrol eden ve bool değer döndüren metot.
        public virtual bool GolVurusu()
        {
            double Gol_Skor = Yetenek * 0.3 +Sut * 0.2 + Kararlilik * 0.1 + Dogal_Form * 0.1 + Hiz * 0.1 + Sans * 0.2;
            if (Gol_Skor > 70)
            {
                return true;

            }
            else
                return false;

        }

    }
}
