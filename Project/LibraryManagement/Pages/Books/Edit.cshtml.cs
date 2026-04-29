using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace LibraryManagement.Pages.Books
{
    public class Edit : PageModel
    {
        [BindProperty]
        public int Id {get; set;}

        [BindProperty]
        public string Title {get; set;} = "";

        [BindProperty]
        public string Author {get; set;} = "";

        [BindProperty]
        public string Genre {get; set;} = "";

        [BindProperty]
        public double Price {get; set;}

        public string ErrorMessage = "";

        public void OnGet(int id)
        {
            try
            {
                using (var connection = new MySqlConnection(
                       "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager"))
                {
                    connection.Open();

                    var command = new MySqlCommand(
                        "SELECT * FROM books WHERE id=@id", connection);

                    command.Parameters.AddWithValue("@id", id);

                    using(var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = reader.GetInt32(0);
                            Title = reader.GetString(1);
                            Author = reader.GetString(2);
                            Genre = reader.GetString(3);
                            Price = reader.GetDouble(4);
                        }
                        else
                        {
                            ErrorMessage = "Book not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }


        public IActionResult OnPost()
        {
            try
            {
                using (var connection = new MySqlConnection(
                        "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager"))
                {
                    connection.Open();

                    var command = new MySqlCommand(
                        "UPDATE books SET title=@title, author=@author, genre=@genre, price=@price WHERE id=@id",
                        connection);
                    
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@title", Title);
                    command.Parameters.AddWithValue("@author", Author);
                    command.Parameters.AddWithValue("@genre", Genre);
                    command.Parameters.AddWithValue("@price", Price);

                    command.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                ErrorMessage = ex.Message;
                return Page();
            }

            TempData["SuccessMessage"] = "Book updated successfully!";
            return RedirectToPage("/Books/Index");
        }
    }
}