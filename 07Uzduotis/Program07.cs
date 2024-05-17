using _07Uzduotis;
using System;

namespace TreciaPaskaita
{
    public class Program07
    {
        public static void Main(string[] args)
        {

            /*Užduotis 1: Knygų Katalogas
                Užduoties Aprašymas:
                Sukurkite klasę Book, kuri turės šias savybes:

                Title (string)
                Author (string)
                Pages (int)
                Sukurkite klasę Library, kuri turės:

                Tris Book masyvą
                Funkciją AddBook(Book book), kuri pridės knygą į nurodytą vietą į masyvą
                Funkciją GetBooksByAuthor(string author), kuri grąžins visas tam tikro autoriaus knygas
                Funckija kuria atspausdina GetBooksByAuthor grazinta masyva
             */


            Book knyga1 = new Book();
            knyga1.Author = "ER";
            knyga1.Title = "Class";
            knyga1.Pages = 100;

            Book knyga2 = new Book("RR", "ToDo", 10);


            Book knyga3 = new Book("Turbo", "ER", 110);

            Library library = new Library();

            library.AddBook(knyga1);
            library.AddBook(knyga2);
            library.AddBook(knyga3);



            library.PrintBooksByAuthor("ER");


            library.RemoveBook(2);

            library.PrintBooksByAuthor("ER");
        }
    }
}
