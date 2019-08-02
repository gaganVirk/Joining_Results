using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningResults
{
    // simple book class    
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
    }
    public class PurchaseOrder
    {
        public int OrderNumber { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>
            {
                new Book { Title = "Learning C# 3.0",
                    Author = "Jesse Liberty",
                    Publisher = "O'Reilly",
                    PublicationYear = 2008 },
                new Book { Title = "Programming C# 3.0",
                    Author = "Jesse Liberty",
                    Publisher = "O'Reilly",
                    PublicationYear = 2008 },
                new Book { Title = "C# 3.0 Cookbook",
                    Author = "Jay Hilyard",
                    Publisher = "O'Reilly",
                    PublicationYear = 2007 },
                new Book { Title = "C# 3.0 in a Nutshell",
                    Author = "Ben Albahari",
                    Publisher = "O'Reilly",
        PublicationYear = 2007 },
                 new Book { Title = "Head First C#",
                     Author = "Andrew Stellman",
                     Publisher = "O'Reilly",
                     PublicationYear = 2007 },
                new Book { Title = "Programming C#, fourth edition",
                    Author = "Jesse Liberty",
                    Publisher = "O'Reilly",
                    PublicationYear = 2005 }

            };
            List<PurchaseOrder> orderList = new List<PurchaseOrder>
            {
                new PurchaseOrder { OrderNumber = 23483, Title = "C# 3.0 Cookbook", Quantity = 57 },
                new PurchaseOrder { OrderNumber = 57284, Title = "Head First C#", Quantity = 42 },
                new PurchaseOrder { OrderNumber = 56389, Title = "Programming C# 3.0", Quantity = 12 },
                new PurchaseOrder { OrderNumber = 95639, Title = "C# 3.0 Cookbook", Quantity = 122 },
                new PurchaseOrder { OrderNumber = 57493, Title = "C# 3.0 in a Nutshell", Quantity = 43 },
                new PurchaseOrder { OrderNumber = 73558, Title = "Programming C# 3.0", Quantity = 99 },
                new PurchaseOrder { OrderNumber = 45385, Title = "C# 3.0 Cookbook", Quantity = 35 }, };
            var resultList = from myBook in bookList join myOrder in orderList on myBook.Title equals myOrder.Title
                             where myOrder.Quantity >= 50 select new { myBook.Title, myBook.Author, myOrder.Quantity };

            Console.WriteLine("Book orders with quantities greater than 50:");
            foreach (var testBook in resultList)
            {
                Console.WriteLine("Title: {0}\tAuthor: {1} \tQuantity: {2}", testBook.Title, testBook.Author, testBook.Quantity); }
        }
    }
}
