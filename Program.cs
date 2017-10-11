using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace One_to_one
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new dbmodel())
            {
                var author = new Author {
                    FirstName = "William",
                    LastName = "Shakespeare",
                    Books = new List<Book>
                    {
                        new Book { Title = "Hamlet"},
                        new Book { Title = "Othello" },
                        new Book { Title = "MacBeth" }
                    }
                };
                context.Add(author);
                context.SaveChanges();
            }

            Console.ReadLine();
        }
    }


}
