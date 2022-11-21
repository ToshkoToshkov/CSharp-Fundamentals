using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp_PhoneBook.Models;

namespace MyFirstWebApp_PhoneBook.Controllers
{
    public class PhoneBookController : Controller
    {
        public IActionResult Index()
        {
            return View(DataContext.Contacts);
        }

        [HttpPost]
        public IActionResult Add(Contact model)
        {
            if (ModelState.IsValid)
            {
                DataContext.Contacts.Add(model);
            }
            else
            {
                TempData["Error"] = "Incorrect data!";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
