using System;

namespace TreciaPaskaita
{

    public class ProgramMetodai 
    {
        public static void Main(string[] args)
        {
            SpausdinkVarda("Ernestas");
            /* Be static 
             * ProgramMetodai program = new ProgramMetodai();
             * program.SpausdinkVarda("Ernestas");
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vardas"></param>
        public static void SpausdinkVarda(string vardas) // Be statik sunkiau iskviesti
        {
            Console.WriteLine(vardas);
        }
    
    }
}
