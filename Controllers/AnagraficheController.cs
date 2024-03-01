using Microsoft.AspNetCore.Mvc;
using S5L5.Models;
using static System.Formats.Asn1.AsnWriter;

namespace S5L5.Controllers
{
    public class AnagraficheController : Controller
    {
        private readonly PoliziaDbContext _context;
        public AnagraficheController(PoliziaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var anagrafica = _context.Anagrafica.ToList();
            return View(anagrafica);
        }
        public IActionResult Add(Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {

                _context.Anagrafica.Add(anagrafica);
                _context.SaveChanges();

                return RedirectToAction("Index", new { id = anagrafica.IdAnagrafica });
            }

            return View(anagrafica);
        }
    }
}
