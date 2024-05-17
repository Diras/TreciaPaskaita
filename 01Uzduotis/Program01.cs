using System;
using System.Diagnostics.Metrics;
using System.Formats.Tar;

namespace TreciaPaskaita
{

    public class Program01
    {
        public static void Main(string[] args)
        {
            //1. Sukurkite metodą, kuris priima metų skaičių ir atspausdina,
            //kiek mėnesių, dienų ir valandų tai yra. Tarkime kad metai turi 365 dienas.
            //Pvz.: "16 metu, tai: 192 menesiu, 5840 dienu, 140160 valandu."
            int years;

            Console.WriteLine("Iveskite metu skaiciu...");
            while (!int.TryParse(Console.ReadLine(), out years))
            {
                Console.WriteLine("Ivestas neteisingai, pabandykite dar karta");
            }

            CalculateMonthsDaysHours(years);


        }
        

        public static void CalculateMonthsDaysHours(int years)
        {
            int months = years *12;
            int days = years *365;
            int hours = days * 24;

            Console.WriteLine($"Ivestas skaicius {years} turi: {months} menesiu, {days} dienu, {hours} valandu");
        }

    }
}
