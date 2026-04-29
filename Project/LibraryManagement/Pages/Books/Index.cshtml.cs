using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace LibraryManagement.Pages.Books
{
    public class Index : PageModel
    {
        public List<BookInfo> listBooks {get; set;} = new List<BookInfo>();

        public void OnGet()
        {
            //list for temporarily check and display the books on frontnend
            // listBooks = new List<BookInfo>
            // {
            //     new BookInfo{Id = 1, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Fiction", Price = 299},
            //     new BookInfo{Id = 2, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Genre = "Finance", Price = 350},
            //     new BookInfo{Id = 3, Title = "Clean Code", Author = "Robert C. Martin", Genre = "Programming", Price = 500}
            // };

            try
            {
                using (var connection = new MySqlConnection(
                        "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager"))
                {
                    connection.Open();

                    var command = new MySqlCommand("SELECT * FROM books", connection);

                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBooks.Add(new BookInfo
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Author = reader.GetString(2),
                                Genre = reader.GetString(3),
                                Price = reader.GetDouble(4)
                            });
                        }
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine($"Error retriving books: {ex.Message}");
            }
        }
    }
    public class BookInfo
    {
        public int Id {get; set;} 
        public string Title {get; set;} = "";

        public string Author {get; set;} = "";

        public string Genre {get; set;} = "";

        public double Price {get;set;}
    }
}