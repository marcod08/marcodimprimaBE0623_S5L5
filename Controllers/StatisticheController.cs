using Microsoft.AspNetCore.Mvc;
using S5L5.Models;

namespace S5L5.Controllers
{
    public class StatisticheController : Controller
    {
        private readonly PoliziaDbContext _context;
        public StatisticheController(PoliziaDbContext context)
        {
            _context = context;
        }
        public IActionResult TotaleVerbaliTrasgressore()
        {
            var totaleVerbaliTrasgressore = _context.Verbale
                                    .GroupBy(v => v.IdAnagrafica)
                                    .Select(g => new TotaleVerbaliTrasgressore
                                    {
                                        IdAnagrafica = g.Key,
                                        TotaleVerbali = g.Count()
                                    })
                                    .ToList();

            return View(totaleVerbaliTrasgressore);
        }
        public IActionResult TotalePuntiDecurtatiTrasgressore()
        {
            var totalePuntiDecurtatiTrasgressore = _context.Verbale
                                    .GroupBy(v => v.IdAnagrafica)
                                    .Select(g => new TotalePuntiDecurtatiTrasgressore
                                    {
                                        IdAnagrafica = g.Key,
                                        TotalePuntiDecurtati = g.Sum(v => v.DecurtamentoPunti)
                                    })
                                    .ToList();

            return View(totalePuntiDecurtatiTrasgressore);
        }
        public IActionResult ViolazioniConPuntiAlti()
        {
            var violazioniAlte = _context.Verbale
                                    .Where(v => v.DecurtamentoPunti > 10)
                                    .Select(v => new ViolazionePuntiAlta
                                    {
                                        Importo = v.Importo,
                                        IdAnagrafica = v.IdAnagrafica,
                                        DataViolazione = v.DataViolazione,
                                        DecurtamentoPunti = v.DecurtamentoPunti
                                    })
                                    .ToList();

            return View(violazioniAlte);
        }
        public IActionResult ViolazioniConImportiAlto()
        {
            var violazioniAlte = _context.Verbale
                                    .Where(v => v.Importo > 400)
                                    .Select(v => new ViolazioneImportoAlta
                                    {
                                        IdAnagrafica = v.IdAnagrafica,
                                        Importo = v.Importo,
                                        DataViolazione = v.DataViolazione,
                                        DecurtamentoPunti = v.DecurtamentoPunti
                                    })
                                    .ToList();

            return View(violazioniAlte);
        }
    }
}
