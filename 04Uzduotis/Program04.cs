using System;
using System.Diagnostics.Metrics;
using System.Formats.Tar;
using System.Runtime.ConstrainedExecution;

namespace TreciaPaskaita
{

    public class Program04
    {
        public static void Main(string[] args)
        {
            /*Sukurkite metodą, kuris suskaičiuoja, kiek vidutiniškai keleivių k važiuoja į Vilnių
	            viename traukinio vagone, jei žinomas traukinio keleivių skaičius n, keleivių, vykstančių
	            ne į Vilnių skaičius m ir vagonų skaičius v. 

	            galite naudoti random skaicius:
            */


            CalculateAveragePassangers();


        }


        public static void CalculateAveragePassangers()
        {
            Random random = new Random();
            int passangers = random.Next(50, 151);
            int passangersNotVisitingVilnius = random.Next(10, 51);
            int carriedges = random.Next(1, 13);
            int averagePassengersGoingToVilnius = (passangers - passangersNotVisitingVilnius)/carriedges;

            Console.WriteLine($"Sugeneruoti skaiciai: {passangers} traukinio keleivių skaičius, " +
                $"{passangersNotVisitingVilnius} keleivių, vykstančių ne į Vilnių, {carriedges} vagonų skaičius");
            Console.WriteLine($"Vidutiniškai {averagePassengersGoingToVilnius} keleiviai/keleivių važiuoja į Vilnių viename traukinio vagone.");
        }

    }
}
