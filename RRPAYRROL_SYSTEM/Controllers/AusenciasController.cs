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
    public class AusenciasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AusenciasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ausencias
        public async Task<IActionResult> Index()
        {
              return _context.Ausencias != null ? 
                          View(await _context.Ausencias.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Ausencias'  is null.");
        }

        // GET: Ausencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ausencias == null)
            {
                return NotFound();
            }

            var ausencia = await _context.Ausencias
                .FirstOrDefaultAsync(m => m.IdAusencia == id);
            if (ausencia == null)
            {
                return NotFound();
            }

            return View(ausencia);
        }

        // GET: Ausencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ausencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAusencia,FechaAusencia,Pagado,Motivo,IdEmpleadoFK")] Ausencia ausencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ausencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ausencia);
        }

        // GET: Ausencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ausencias == null)
            {
                return NotFound();
            }

            var ausencia = await _context.Ausencias.FindAsync(id);
            if (ausencia == null)
            {
                return NotFound();
            }
            return View(ausencia);
        }

        // POST: Ausencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAusencia,FechaAusencia,Pagado,Motivo,IdEmpleadoFK")] Ausencia ausencia)
        {
            if (id != ausencia.IdAusencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ausencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AusenciaExists(ausencia.IdAusencia))
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
            return View(ausencia);
        }

        // GET: Ausencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ausencias == null)
            {
                return NotFound();
            }

            var ausencia = await _context.Ausencias
                .FirstOrDefaultAsync(m => m.IdAusencia == id);
            if (ausencia == null)
            {
                return NotFound();
            }

            return View(ausencia);
        }

        // POST: Ausencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ausencias == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ausencias'  is null.");
            }
            var ausencia = await _context.Ausencias.FindAsync(id);
            if (ausencia != null)
            {
                _context.Ausencias.Remove(ausencia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AusenciaExists(int id)
        {
          return (_context.Ausencias?.Any(e => e.IdAusencia == id)).GetValueOrDefault();
        }
    }
}
