using System;
using System.Diagnostics.Metrics;
using System.Formats.Tar;

namespace TreciaPaskaita
{

    public class Program02
    {
        public static void Main(string[] args)
        {
            //Sukurkite metodą, kuris pagal šiuo metu esančių valandų bei minučių skaičių
            //(naudokite parametrus hour ir minute iš DateTime) apskaičiuoja kiek minučių
            //ir sekundžių praėjo po vidurnakčio.
            //Pvz.: "Siuo metu yra 14val. 33min., tai praejo 873 minutes (arba 52380 sekundziu) po vidurnakcio."
            //galime naudoti tokius parametrus iš DateTime tipo objekto:
            //	DateTime.Now.Hour
            //	DateTime.Now.Minute

            CalculateMinutesAndSeconds();

        }


        public static void CalculateMinutesAndSeconds()
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;

            Console.WriteLine($"Siuo metu yra {hours} val. {minutes} min., tai praejo: {hours*60} minutes (arba {hours*3600 + minutes*60} sekundziu) po vidurnakcio.");
        }
    }
}
