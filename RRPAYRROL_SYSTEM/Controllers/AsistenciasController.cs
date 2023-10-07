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
    public class AsistenciasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AsistenciasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Asistencias
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Asistencias.Include(a => a.Empleado).Include(a => a.Estado).Include(a => a.Proyecto);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Asistencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Asistencias == null)
            {
                return NotFound();
            }

            var asistencia = await _context.Asistencias
                .Include(a => a.Empleado)
                .Include(a => a.Estado)
                .Include(a => a.Proyecto)
                .FirstOrDefaultAsync(m => m.IdAsistencia == id);
            if (asistencia == null)
            {
                return NotFound();
            }

            return View(asistencia);
        }

        // GET: Asistencias/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Codigo");
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "estado");
            ViewData["IdProyecto"] = new SelectList(_context.Proyectos, "IdProyecto", "Cliente");
            return View();
        }

        // POST: Asistencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAsistencia,FechaEntrada,FechaSalida,IdProyecto,IdEmpleado,IdEstado")] Asistencia asistencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asistencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Codigo", asistencia.IdEmpleado);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "estado", asistencia.IdEstado);
            ViewData["IdProyecto"] = new SelectList(_context.Proyectos, "IdProyecto", "Cliente", asistencia.IdProyecto);
            return View(asistencia);
        }

        // GET: Asistencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Asistencias == null)
            {
                return NotFound();
            }

            var asistencia = await _context.Asistencias.FindAsync(id);
            if (asistencia == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Codigo", asistencia.IdEmpleado);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "estado", asistencia.IdEstado);
            ViewData["IdProyecto"] = new SelectList(_context.Proyectos, "IdProyecto", "Cliente", asistencia.IdProyecto);
            return View(asistencia);
        }

        // POST: Asistencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAsistencia,FechaEntrada,FechaSalida,IdProyecto,IdEmpleado,IdEstado")] Asistencia asistencia)
        {
            if (id != asistencia.IdAsistencia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asistencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsistenciaExists(asistencia.IdAsistencia))
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
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "Codigo", asistencia.IdEmpleado);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "estado", asistencia.IdEstado);
            ViewData["IdProyecto"] = new SelectList(_context.Proyectos, "IdProyecto", "Cliente", asistencia.IdProyecto);
            return View(asistencia);
        }

        // GET: Asistencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Asistencias == null)
            {
                return NotFound();
            }

            var asistencia = await _context.Asistencias
                .Include(a => a.Empleado)
                .Include(a => a.Estado)
                .Include(a => a.Proyecto)
                .FirstOrDefaultAsync(m => m.IdAsistencia == id);
            if (asistencia == null)
            {
                return NotFound();
            }

            return View(asistencia);
        }

        // POST: Asistencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Asistencias == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Asistencias'  is null.");
            }
            var asistencia = await _context.Asistencias.FindAsync(id);
            if (asistencia != null)
            {
                _context.Asistencias.Remove(asistencia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AsistenciaExists(int id)
        {
          return (_context.Asistencias?.Any(e => e.IdAsistencia == id)).GetValueOrDefault();
        }
    }
}
