using System;
using System.Diagnostics.Metrics;
using System.Formats.Tar;
using System.Runtime.ConstrainedExecution;

namespace TreciaPaskaita
{

    public class Program03
    {
        public static void Main(string[] args)
        {
            /*Sukurkite metodą, kuris suskaičiuoja, kiek knygų k vidutiniškai per metus perskaito
                vienas mokyklos bibliotekos lankytojas.Žinomas vidutiniškai per mėnesį perskaitytų
                knygų skaičius v ir vidutiniškai per metus apsilankiusių bibliotekoje skaičius n. 
                galite naudoti random skaicius:
            */


            CalculateAverageReadedBooks();


        }


        public static void CalculateAverageReadedBooks()
        {
            Random random = new Random();
            int averageBooksPerMonth = random.Next(10, 51);
            int averageVisitorsPerYear = random.Next(10, 51);
            int averageBooksPerVisitor = averageBooksPerMonth * 12 / averageVisitorsPerYear;

            Console.WriteLine($"Sugeneruoti skaiciai: {averageBooksPerMonth} knygu vidurkis per men., {averageVisitorsPerYear} lankytoju skaicius per metus");
            Console.WriteLine($"Vidutiniškai per metus perskaito vienas mokyklos bibliotekos lankytojas {averageBooksPerVisitor} knygu");
        }

    }
}
