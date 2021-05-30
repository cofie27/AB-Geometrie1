using System;
using System.Collections.Generic;
using System.Text;

namespace AB_Geometrie1
{
    class Rechteck
    {
        private double SeiteA;
        private double SeiteB;
        private double Umfang;
        private double Flaeche;
        private double Diagonallaenge;


        public Rechteck()
        {
            SeiteA = 1;
            SeiteB = 2;
            Umfang = 0;
            Flaeche = 0;

        }
        public void EingabeSeiten()
        {
            Console.WriteLine("Bitte Seite A eingeben: ");
            SeiteA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Seite B eingeben: ");
            SeiteB = Convert.ToInt32(Console.ReadLine());

        }
        public void DruckeSeiten()
        {
            Console.WriteLine("Seite A: " + SeiteA);
            Console.WriteLine("Seite B: " + SeiteB);

        }
        public void DruckeUmfang()
        {
            Umfang = 2*(SeiteA + SeiteB);
            Console.WriteLine("Umfang: " + Umfang);
        }
        public void DruckeFlaeche()
        {
            Flaeche = (SeiteA * SeiteB);
            Console.WriteLine("Flaeche: " + Flaeche);

        }
        public void DruckeDiagonallaenge ()
        {
            Diagonallaenge = (Math.Sqrt(SeiteA * SeiteA + SeiteB * SeiteB));
            Console.WriteLine("Diagnoallaenge: " + Diagonallaenge);
        }
    }
}
