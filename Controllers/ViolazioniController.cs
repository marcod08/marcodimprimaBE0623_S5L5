using Microsoft.AspNetCore.Mvc;
using S5L5.Models;

namespace S5L5.Controllers
{
    public class ViolazioniController : Controller
    {
        private readonly PoliziaDbContext _context;
        public ViolazioniController(PoliziaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var violazione = _context.Violazione.ToList();
            return View(violazione);
        }
        public IActionResult Add(Violazione violazione)
        {
            if (ModelState.IsValid)
            {

                _context.Violazione.Add(violazione);
                _context.SaveChanges();

                return RedirectToAction("Index", new { id = violazione.IdViolazione });
            }

            return View(violazione);
        }
    }
}
