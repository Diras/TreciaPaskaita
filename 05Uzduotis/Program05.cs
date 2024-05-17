using System;
using System.Diagnostics.Metrics;
using System.Formats.Tar;
using System.Runtime.ConstrainedExecution;

namespace TreciaPaskaita
{

    public class Program05
    {
        public static void Main(string[] args)
        {
            /*Tema: Studentų pažymių analizė

                Užduotis: Parašykite C# programą, kuri atliktų šiuos veiksmus:

                Sukurtų masyvą iš n studentų pažymių (atsitiktinių skaičių intervale nuo 1 iki 10).
                Naudotų ciklus, kad:
                Atspausdintų visus pažymius.
                Apskaičiuotų ir atspausdintų pažymių vidurkį.
                Apskaičiuotų ir atspausdintų didžiausią ir mažiausią pažymį.
                Parašytų funkciją, kuri priimtų masyvą kaip parametrą ir grąžintų visų teigiamų pažymių skaičių nuo 5.
                Parašytų funkciją, kuri priimtų masyvą kaip parametrą ir grąžintų visų pažymių sumą.
            */

            int numberOfStudents;
            Random random = new Random();

            Console.WriteLine("Iveskite studentu skaiciu...");
            while (!int.TryParse(Console.ReadLine(), out numberOfStudents))
            {
                Console.WriteLine("Ivestas neteisingas sakicius, pabandykite dar karta");
            }

            int[] grades = new int[numberOfStudents];
            int gradesSum = 0;
            int mingGrade = 10;
            int maxGrade = 1;

            for (int i = 0; i < numberOfStudents; i++)
            {
                grades[i] = random.Next(1, 11);
                if (i < numberOfStudents - 1)
                {
                    Console.WriteLine(grades[i] + ", ");
                }
                else 
                {
                    Console.WriteLine(grades[i]);
                }
               
                gradesSum += grades[i];

                if (grades[i] < mingGrade)
                {
                    mingGrade = grades[i];
                }

                if (grades[i] > maxGrade)
                {
                    maxGrade = grades[i];
                }

            }

            
            Console.WriteLine($"Pažymių vidurkis: {gradesSum / numberOfStudents}" );
            Console.WriteLine($"Didžiausias {maxGrade} ir mažiausias {mingGrade} pažymiai");
            Console.WriteLine($"Visų teigiamų pažymių skaičius: {CalculateGradesMoreThan5(grades)}");
            Console.WriteLine($"Visų pažymių sumą: {CalculateGradesSum(grades)}");

        }


       

        public static int CalculateGradesMoreThan5( int[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]  >= 5)
                {
                    number++;
                }
            }
            return number;
        }

        public static int CalculateGradesSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 5)
                {
                    sum += array[i];
                }
            }
            return sum;
        }



    }
}
