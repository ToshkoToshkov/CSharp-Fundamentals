using Microsoft.AspNetCore.Mvc;
using MyPhoneBook.Models;
using Phonebook.Models;

namespace Phonebook.Controllers
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
                TempData["Error"] = "Incorrect Data!";
            }

            return RedirectToAction(nameof(index));
        }
    }
}
