using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

public class StudentController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}