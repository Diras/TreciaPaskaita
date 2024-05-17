using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Uzduotis
{
    /*Užduotis 1: Knygų Katalogas
                Užduoties Aprašymas:
                Sukurkite klasę Book, kuri turės šias savybes:

                Title (string)
                Author (string)
                Pages (int)
                Sukurkite klasę Library, kuri turės:

                Book masyvą
                Funkciją AddBook(Book book), kuri pridės knygą į nurodytą vietą į masyvą
                Funkciją GetBooksByAuthor(string author), kuri grąžins visas tam tikro autoriaus knygas
                Funckija kuria atspausdina GetBooksByAuthor grazinta masyva


                Patobilinti AddBook metodą, kad jis praplėstų masyvo dydį kaskart pridėdamas naują knygą.
                Sukurti funkciją RemoveBook(int index) kuri pašalina knyga 
                 iš masyvo pagal norodytą index'ą ir sumažina masyvą, nepalieka tarpo, 
                paslenka knygas taip kad nebūtų null elementų.
                (Masyvas inicializavus klasę Library turi būti [0]) (edited) 
             
             */
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }


        public Book()
        {
           
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        
    }


    public class Library
    {
        public Book[] Books { get; set; }

        
        public Library()
        {
            Books = new Book[0];
        }
        


        public void AddBook(Book book, int bookIndex)
        {
            Books[bookIndex] = book;
        }

        public void AddBook(Book book)
        {
            int arrayLength = Books.Length; // rewikia is seno masyvo perduoti i nauja
            arrayLength++;
            Book[] tempArray = Books; 
            Books = new Book[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                if (i == tempArray.Length)
                {
                    Books[i] = null;
                }
                else
                {
                    Books[i] = tempArray[i];
                }
                
            }

            Books[arrayLength - 1] = book;


        }

        public void RemoveBook(int index)
        {
            Books[index] = null;

            Book[] tempArray = new Book[Books.Length - 1];
            int tempIndex = 0;

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] != null)
                {
                    tempArray[tempIndex] = Books[i];
                    tempIndex++;
                }
            }

            Books = tempArray;
        }


        public Book[] GetBooksByAuthor(string author)
        {
            int booksCount = 0;
            foreach (var book in Books)
            {
                if(book != null && book.Author == author)
                {
                    booksCount++;
                }
            }

            Book[] foundBooks = new Book[booksCount];
            int index = 0;

            foreach (var book in Books)
            {
                if (book != null && book.Author == author)
                {
                    foundBooks[index] = book;
                    index++;
                }
            }

            return foundBooks;
        }


        public void PrintBooksByAuthor(string author)
        {
            Book[] booksByAuthor = GetBooksByAuthor(author);

            if (booksByAuthor.Length > 0)
            {
                Console.WriteLine($"Knygos autoriaus {author}:");
                foreach (var book in booksByAuthor)
                {
                    Console.WriteLine($"Pavadinimas {book.Title}. Puslapiu skaicius {book.Pages}");
                }
            }
            else
            {
                Console.WriteLine($"Nerasta knygų autoriaus {author}.");
            }
        }
    }
}
