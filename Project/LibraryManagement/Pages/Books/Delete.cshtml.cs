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
    public class Delete : PageModel
    {
        [BindProperty]
        public int Id {get; set;}

        public string ErrorMessage = "";

        public void OnGet(int id)
        {
            Id = id;
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
                            "DELETE FROM books WHERE id=@id", connection);

                    command.Parameters.AddWithValue("@id", Id);
                    command.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                ErrorMessage = ex.Message;
                return Page();
            }

            TempData["SuccessMessage"] = "Book Deleted Successfully!";
            return RedirectToPage("/Books/Index");
        }
    }
}