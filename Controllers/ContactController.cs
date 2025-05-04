using Microsoft.AspNetCore.Mvc;
using contact_form.Data;
using contact_form.Models;

namespace ContactFormApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(model);
                _context.SaveChanges();
                ViewBag.Success = true;
            }
            return View();
        }
    }
}
