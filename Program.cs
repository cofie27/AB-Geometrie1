using System;

namespace AB_Geometrie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------Dreieck-----------------------------------");
            Dreieck d1 = new Dreieck();
            Console.WriteLine("-----------------------------------Berechnung--------------------------------");
            d1.EingabeSeiten();
            d1.DruckeSeiten();
            Console.WriteLine("-----------------------------------Ergebnisse--------------------------------");
            d1.DruckeUmfang();
            d1.DruckeFlaeche();

            Console.WriteLine("-------------------------------------Kreis----------------------------------");
            Kreis k1 = new Kreis();
            Console.WriteLine("-----------------------------------Berechnung--------------------------------");
            k1.EingabeRadius();
            Console.WriteLine("-----------------------------------Ergebnisse--------------------------------");
            k1.DruckeRadius();           
            k1.DruckeUmfang();
            k1.DruckeFlaeche();
            k1.DruckeDurchmesser();

            Console.WriteLine("------------------------------------Rechteck---------------------------------");
            Rechteck r1 = new Rechteck();
            Console.WriteLine("-----------------------------------Berechnung--------------------------------");
            r1.EingabeSeiten();
            Console.WriteLine("-----------------------------------Ergebnisse--------------------------------");
            r1.DruckeSeiten();
            r1.DruckeUmfang();
            r1.DruckeFlaeche();
            r1.DruckeDiagonallaenge();

            //Dreieck1: A=4.47 U=10;
            //Dreieck2: A= 10,95 U=21
            //Dreieck3: SeiteA ist negativ ->Fehler
            //Dreieck4: negative Wurzel -> Fehler
        }
    }
}
