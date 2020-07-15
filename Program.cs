using System;
using System.Collections.Generic;

namespace library_system
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Mandy";

            int coolnessFactor = 100;

            double someDecimal = 2.2;

            List<double> temperatures = new List<double>(){2.2, 1.0, 4.2};


//             let warAndPeace = {
//     title: "War and Peace",
//     author: "Leo Tolstoy",
//     ISBN: 1234455559599495959449,
//     numberOfPages: 10000000,
//     patronHistory: [],
//     coverPhoto: "image.jpg",
//     publishingCompany: "Russia",
//     yearReleased: 1880
// }

        Book WarAndPeace = new Book(){
            Title = "War and Peace",
            Author = "Leo Tolstoy",
            ISBN = 12345
        };

        Book AnnaKarrererereigneirnawe = new Book("Anna Kareirueoriueworieur", "Leo Tolstoy");

        Console.WriteLine($"{WarAndPeace.Title} by {WarAndPeace.Author}");

        List<Book> LibraryInventory = new List<Book>(){
            WarAndPeace,
            AnnaKarrererereigneirnawe,
            new Book("The Brothers Karamazov", "Another russian dude"){
                ISBN = 1234
            }
        };

        LibraryInventory.ForEach(book => Console.WriteLine(book.Title));

        Patron steve = new Patron(){
            LastName = "Brownlee",
        };

        steve.FirstName = "Steeeeeeeeeeve";

        steve.CheckOutBook(WarAndPeace);
        Console.WriteLine();

        Librarian Sarah = new Librarian(){
            FirstName = "Sarah",
            LastName = "Brooks",
            Email = "sarah@sarah.com"
        };











// Won't work! We need to store more than just strings.
            // Dictionary<string, string> warAndPeace = new Dictionary<string, string>(){
            //     {"Title", "War and Peace"},
            //     {"Author", "Leo Tolstoy"},
            //     {"ISBN", 12345},
            //     {"NumberOfPages": 100000},
            //     {}
            // };

        }
    }
}
