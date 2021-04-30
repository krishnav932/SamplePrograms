using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Book
    {
        public string name { get; set; }
        public int price { get; set; }
        public string author { get; set; }
    }
    class demo
    {
        static void Main()
        {
            List<Book> Books = new List<Book>() {
            new Book { name = "Maths", price = 400, author="Ram" },
            new Book { name = "Social", price = 300 , author="Shyam"},
            new Book { name = "Science", price = 600, author="Prasad" }
         };
            var names = Books.Select(x => x.name);
            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            var prices = Books.Select(x => x.price);
            foreach (var price in prices)
            {
                Console.WriteLine(price);

            }
            var authors = Books.Select(x => x.author);
            foreach (var author in authors)
            {
                Console.WriteLine(author);

            }
            Console.Read();
        }
    }
}
  
