using System;
using System.Collections.Generic;
using System.Text;

namespace AB_Geometrie1
{
    class Kreis
    {
        private int Radius;
        private double Durchmesser;
        private double Umfang;
        private double Flaeche;

        public Kreis()
        {
            Radius = 1;
            Durchmesser = 2;
            Umfang = 0;
            Flaeche = 0;

        }
        public void EingabeRadius()
        {
            Console.WriteLine("Bitte Radius eingeben: ");
            Radius = Convert.ToInt32(Console.ReadLine());


        }
        public void DruckeRadius()
        {
            Console.WriteLine(Radius);


        }
        public void DruckeUmfang()
        {
            Umfang = 2 * Math.PI * Radius;
            Console.WriteLine("Umfang: " + Umfang);
        }
        public void DruckeFlaeche()
        {
            Flaeche = Math.PI * Radius * Radius;
            Console.WriteLine("Flaeche: " + Flaeche);

        }
        public void DruckeDurchmesser()
        {
            Durchmesser = 2 * Radius;
            Console.WriteLine("Durchmesser: " + Durchmesser);
        }
    }
}