using System;
using System.Collections.Generic;
using System.Text;

namespace AB_Geometrie1
{
    class Dreieck
    {
        private int SeiteA;
        private int SeiteB;
        private int SeiteC;
        private int Umfang;
        private double Flaeche;
        private int s;

        public Dreieck()
        {
            SeiteA = 1;
            SeiteB = 2;
            SeiteC = 3;
            Umfang = 0;
            Flaeche = 0;
            //s = 0;

        }
        public void EingabeSeiten()
        {
            Console.WriteLine("Bitte Seite A eingeben: ");
            SeiteA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Seite B eingeben: ");
            SeiteB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Seite C eingeben: ");
            SeiteC = Convert.ToInt32(Console.ReadLine());
        }
        public void DruckeSeiten()
        {
            Console.WriteLine("Seite A: " + SeiteA);
            Console.WriteLine("Seite B: " + SeiteB);
            Console.WriteLine("Seite C: " + SeiteC);
        }
        public void DruckeUmfang()
        {
            Umfang = SeiteA + SeiteB + SeiteC;
            Console.WriteLine("Umfang: " + Umfang);
        }
        public void DruckeFlaeche()
        {
            //s = Umfang / 2;
            s = (SeiteA + SeiteB + SeiteC) / 2;
            Flaeche = Math.Sqrt(s * (s - SeiteA) * (s - SeiteB) * (s - SeiteC));
            Console.WriteLine("Flaeche: " + Flaeche);

        }
    }

}
