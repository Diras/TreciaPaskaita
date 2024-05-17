using System;

namespace TreciaPaskaita
{
    public class Program06
    {
        public static void Main(string[] args)
        {

            /*ukurkite funkciją kuriai paduodame du double skaicius 
             * bei matematinio veiksmo (+,-/,*) operatorių kaip string 
             * ir pagal tą operatorių funkcija atlika veiksmą ir grąžina rezultatą
             * */

            double number1;
            double number2;
            string veiksmas;

            Console.WriteLine("Įveskite pirmą skaičių...");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Įvestas neteisingai, bandykite dar kartą");
            }

            Console.WriteLine("Įveskite antrą skaičių...");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Įvestas neteisingai, bandykite dar kartą");
            }

            Console.WriteLine("Įveskite veiksmo (+, -, *, /) operatorių...");
            veiksmas = Console.ReadLine();
            while ((veiksmas != "+" && veiksmas != "-" && veiksmas != "*" && veiksmas != "/") || (veiksmas == "/" && number2 == 0))
            {
                if (veiksmas == "/" && number2 == 0)
                {
                    Console.WriteLine("Dalyba is nulio negalima, bandykite dar kartą");
                }
                else
                {
                    Console.WriteLine("Neteisingai įvestas operatorius, bandykite dar kartą");
                }
                
                veiksmas = Console.ReadLine();
            }

           
            Console.WriteLine($"Rezultatas: {Calculate(number1, number2, veiksmas)}");
        }

        public static double Calculate(double number1, double number2, string veiksmas)
        {
            switch (veiksmas)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    return 0;

            }
        }
    }
}
