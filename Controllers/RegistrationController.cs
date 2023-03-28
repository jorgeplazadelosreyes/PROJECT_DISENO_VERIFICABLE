using Microsoft.AspNetCore.Mvc;
using PROJECT1.Data;
using PROJECT1.Models;

namespace PROJECT1.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RegistrationController( ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Registration> objRegistrationList = _db.Registrations;
            return View(objRegistrationList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registration obj)
        {
            if (ModelState.IsValid) { 
                _db.Registrations.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var registrationFromDb = _db.Registrations.Find(id);
            if (registrationFromDb == null)
            {
                return NotFound();
            }
            return View(registrationFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Registration obj)
        {
            if (ModelState.IsValid)
            {
                _db.Registrations.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
