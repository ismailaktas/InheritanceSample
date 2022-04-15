using System;

namespace sampleConsoleApp
{
    public class vasita
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int tekerlekSayisi { get; set; }
        public int motorGucu { get; set; }

        public void vasitaBilgileri()
        {
            Console.WriteLine(marka + ", " + model + ", " + tekerlekSayisi.ToString() + ", " + motorGucu.ToString());
        }

    }

    public class otomobil : vasita
    {
        public string cekisTuru { get; set; }
        public int kapiSayisi { get; set; }

        public void otomobilBilgileri()
        {
            Console.WriteLine(cekisTuru + ", " + kapiSayisi.ToString());
        }
    }

    public class motosiklet : vasita
    {
        public bool otomatikVites { get; set; }

        public void motosikletBilgileri()
        {
            Console.WriteLine(otomatikVites.ToString());
        }
    }

    public class bisiklet : vasita
    {
        public string kullanimTuru { get; set; }

        public void bisikletBilgileri()
        {
            Console.WriteLine(kullanimTuru);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******************************************************");

            otomobil objOtomobil = new otomobil();
            //Kalıtımdan gelenler
            objOtomobil.marka = "Porsche";
            objOtomobil.model = "Panamera";
            objOtomobil.tekerlekSayisi = 4;
            objOtomobil.motorGucu = 3000;

            //Otomobil nesnesinde olanlar
            objOtomobil.cekisTuru = "4x4";
            objOtomobil.kapiSayisi = 4;

            objOtomobil.vasitaBilgileri();
            objOtomobil.otomobilBilgileri();


            Console.WriteLine("*******************************************************");

            motosiklet objMotosiklet = new motosiklet();
            //Kalıtımdan gelenler
            objMotosiklet.marka = "Honda";
            objMotosiklet.model = "Forza";
            objMotosiklet.tekerlekSayisi = 2;
            objMotosiklet.motorGucu = 400;

            //Motosiklet nesnesinde olanlar
            objMotosiklet.otomatikVites = true;

            objMotosiklet.vasitaBilgileri();
            objMotosiklet.motosikletBilgileri();


            Console.WriteLine("*******************************************************");

            bisiklet objBisiklet = new bisiklet();
            //Kalıtımdan gelenler
            objBisiklet.marka = "Dahon";
            objBisiklet.model = "D8";
            objBisiklet.tekerlekSayisi = 2;
            objBisiklet.motorGucu = 0;

            //Bisiklet nesnesinde olanlar
            objBisiklet.kullanimTuru = "Şehir";

            objBisiklet.vasitaBilgileri();
            objBisiklet.bisikletBilgileri();

        }
    }
}