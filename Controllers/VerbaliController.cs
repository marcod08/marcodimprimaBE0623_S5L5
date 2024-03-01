using Microsoft.AspNetCore.Mvc;
using S5L5.Models;

namespace S5L5.Controllers
{
    public class VerbaliController : Controller
    {
        private readonly PoliziaDbContext _context;
        public VerbaliController(PoliziaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var verbale = _context.Verbale.ToList();

            return View(verbale);
        }
        public IActionResult Add(Verbale verbale)
        {
            if (ModelState.IsValid)
            {
                _context.Verbale.Add(verbale);
                _context.SaveChanges();

                return RedirectToAction("Index", new { id = verbale.IdVerbale });
            }

            return View(verbale);
        }
    }
}
