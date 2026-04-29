using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace LibraryManagement.Pages.Books
{
    public class CreateModel : PageModel
    {   
        [BindProperty, Required(ErrorMessage = "Enter title")]
        public string Title {get; set;} = "";

        [BindProperty, Required(ErrorMessage = "Enter author")]
        public string Author{get; set;} = "";

        [BindProperty, Required(ErrorMessage ="Enter genre")]
        public string Genre {get; set;} = "";

        [BindProperty, Required(ErrorMessage = "Enter price")]
        public double? Price {get; set;} 

        public string ErrorMessage = "";
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {   
            Console.WriteLine($"Title: {Title}, Author: {Author}, Genre: {Genre}, Price: {Price}");
            
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Form is invalid");
                return Page();
            }

            try
            {
                using (var connection = new MySqlConnection(
                        "Server=localhost;Port=3306;Database=dkte;Uid=root;Pwd=manager"))
                {
                    connection.Open();

                    var command = new MySqlCommand(
                        "INSERT INTO books (title, author, genre, price) VALUES (@title, @author, @genre, @price)",
                        connection);

                    command.Parameters.AddWithValue("@title", Title);
                    command.Parameters.AddWithValue("@author", Author);
                    command.Parameters.AddWithValue("@genre", Genre);
                    command.Parameters.AddWithValue("@price", Price);

                    command.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                Console.WriteLine("Error adding book : "+ ex.Message);
                return Page();
            }

            TempData["SuccessMessage"] = "Book added successfully!";

            return RedirectToPage("/Books/Index");
        }
    }
}