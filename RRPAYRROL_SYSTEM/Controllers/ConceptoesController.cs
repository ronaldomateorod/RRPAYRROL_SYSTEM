using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RRPAYRROL_SYSTEM.Models;

namespace RRPAYRROL_SYSTEM.Controllers
{
    public class ConceptoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConceptoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Conceptoes
        public async Task<IActionResult> Index()
        {
              return _context.Conceptos != null ? 
                          View(await _context.Conceptos.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Conceptos'  is null.");
        }

        // GET: Conceptoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Conceptos == null)
            {
                return NotFound();
            }

            var concepto = await _context.Conceptos
                .FirstOrDefaultAsync(m => m.IdConcepto == id);
            if (concepto == null)
            {
                return NotFound();
            }

            return View(concepto);
        }

        // GET: Conceptoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conceptoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdConcepto,NombreConcepto,Tipo,Monto,Porcentaje,IdDetalleNominaFK")] Concepto concepto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(concepto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(concepto);
        }

        // GET: Conceptoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Conceptos == null)
            {
                return NotFound();
            }

            var concepto = await _context.Conceptos.FindAsync(id);
            if (concepto == null)
            {
                return NotFound();
            }
            return View(concepto);
        }

        // POST: Conceptoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdConcepto,NombreConcepto,Tipo,Monto,Porcentaje,IdDetalleNominaFK")] Concepto concepto)
        {
            if (id != concepto.IdConcepto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concepto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConceptoExists(concepto.IdConcepto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(concepto);
        }

        // GET: Conceptoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Conceptos == null)
            {
                return NotFound();
            }

            var concepto = await _context.Conceptos
                .FirstOrDefaultAsync(m => m.IdConcepto == id);
            if (concepto == null)
            {
                return NotFound();
            }

            return View(concepto);
        }

        // POST: Conceptoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Conceptos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Conceptos'  is null.");
            }
            var concepto = await _context.Conceptos.FindAsync(id);
            if (concepto != null)
            {
                _context.Conceptos.Remove(concepto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConceptoExists(int id)
        {
          return (_context.Conceptos?.Any(e => e.IdConcepto == id)).GetValueOrDefault();
        }
    }
}
