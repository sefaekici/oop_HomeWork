

using System;
using System.Collections.Generic;


namespace Ödev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rastgele sayiların aynı olmadığını belirlemek için kullanılan değişkenler.
            int formaNo;
            int Kontrol;
            bool gol_olabilir = true;
           
           //Takim isminde liste oluşturma.
            List<Futbolcu> takim = new List<Futbolcu>();
            //takimin elamanlarını belirleme.
            takim.Add(new Futbolcu ("Oguzhan Kara",1));
            takim.Add(new Defans("Enes Kurt", 2));
            takim.Add(new Defans("Talip Guler", 3));
            takim.Add(new Defans("Derda Battal", 4));
            takim.Add(new Defans("Melih Nalbant", 5));
            takim.Add(new OrtaSaha("Rasit Ceylan", 6));
            takim.Add(new OrtaSaha("Nurullah Bolukbasi", 7));
            takim.Add(new OrtaSaha("Tahsin Celenk", 8));
            takim.Add(new OrtaSaha("Emrullah Guney", 9));
            takim.Add(new Forvet("Dogukan Guler", 10));
            takim.Add(new Forvet("Sefa Ekici", 11));
            Random RastgeleOyuncu = new Random();
            //Değişkenleri döngüde kullanmak için başlangıç değeri atanmıştır.
            formaNo = RastgeleOyuncu.Next(2, 12);
            Kontrol = formaNo;
            
            //3 adet pas için oluşturulan for döngüsü
            for (int i = 0; i < 3; i++)
            {
                Kontrol = formaNo;
                //farklı değer atanana kadar dönen while döngüsü.
                while (formaNo == Kontrol)
                {
                    formaNo = RastgeleOyuncu.Next(2, 12);

                }

                //takım dizisindeki oyuncunun pası başarısız ise içeriye giren kontrol.
                if (!takim[formaNo - 1].Pasver())
                {
                    //0.5 saniye gecikme oluşturan sınıf.
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(formaNo +" "+"Numarali Oyuncunun Pasi Basarisiz");
                    //boola false değeri atanarak pas başarısız ise gol olma ihtimali ortadan kaldırılır.
                    gol_olabilir = false;
                   

                }

                else
                {
                    //0.7 saniye gecikme oluşturan sınıf.
                    System.Threading.Thread.Sleep(700);
                    Console.WriteLine(formaNo +" "+"Numarali Oyuncunun Pasi Basarili...");
                }
            }
            Kontrol = formaNo;
            //gol atanla bir önceki pası atan aynı olmaması için eklenmiş döngü.
            while (Kontrol == formaNo) {
                //kaleciyi almaması için 2 den başlamıştır.
                formaNo = RastgeleOyuncu.Next(2, 12);

            }
            //gol_olabilir değişkeni true değerde ise kontrolün gövdesi çalışır.
            if (gol_olabilir == true)
            {
                //oyuncu gol olma şartını sağlıyorsa if in gövdesi çalışır.
                if (takim[formaNo - 1].GolVurusu())
                {
                    //0.7 saniye gecikme oluşturan sınf
                    System.Threading.Thread.Sleep(700);
                    Console.WriteLine(formaNo +" "+"Kaleciyle Göz Göze Geldi");
                    //1 saniye gecikme oluşturan sınıf.
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(formaNo +" "+"GOOOOOOL TOP AGLARDA!!!");
                }
                //gol olma şartı sağlanmıyorsa else gövdesi çalışır.
                else
                {
                    //0.4 saniye gecikme oluşturan sınıf
                    System.Threading.Thread.Sleep(400);
                    Console.WriteLine(formaNo +" "+"Kaleciyle Karsi Karsiya");
                    //0.7 saniye gecikme olusturan sınıf
                    System.Threading.Thread.Sleep(700);
                    Console.WriteLine(formaNo +"Inanılmaz!!!,Kacirdi");
                }
            }
            //değil ise else gövdesi çalışır.
            else
            {
                //0.7 saniye gecikme olusturan sınıf.
                System.Threading.Thread.Sleep(700);
                Console.WriteLine("Atak Basarisiz");
            }
              
            
            Console.ReadKey();
        }
    }
}
