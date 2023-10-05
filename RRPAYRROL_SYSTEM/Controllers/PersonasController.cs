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
    public class PersonasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Personas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Personas.Include(p => p.Municipio).Include(p => p.Nacionalidad).Include(p => p.Provincia);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Personas == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .Include(p => p.Municipio)
                .Include(p => p.Nacionalidad)
                .Include(p => p.Provincia)
                .FirstOrDefaultAsync(m => m.IdPersona == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            ViewData["IdMunicipioFK"] = new SelectList(_context.Municipios, "IdMunicipio", "IdMunicipio");
            ViewData["IdNacionalidadFK"] = new SelectList(_context.Nacionalidades, "IdNacionalidad", "nacionalidad");
            ViewData["IdProvinciaFK"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia");
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPersona,Nombre,Apellido,FechaNacimiento,Cedula,Direccion,Celular,Telefono,Email,Sexo,FechaCreacion,IdNacionalidadFK,IdMunicipioFK,IdProvinciaFK,CreadoPor,ModificadoPor")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdMunicipioFK"] = new SelectList(_context.Municipios, "IdMunicipio", "IdMunicipio", persona.IdMunicipioFK);
            ViewData["IdNacionalidadFK"] = new SelectList(_context.Nacionalidades, "IdNacionalidad", "nacionalidad", persona.IdNacionalidadFK);
            ViewData["IdProvinciaFK"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia", persona.IdProvinciaFK);
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Personas == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            ViewData["IdMunicipioFK"] = new SelectList(_context.Municipios, "IdMunicipio", "IdMunicipio", persona.IdMunicipioFK);
            ViewData["IdNacionalidadFK"] = new SelectList(_context.Nacionalidades, "IdNacionalidad", "nacionalidad", persona.IdNacionalidadFK);
            ViewData["IdProvinciaFK"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia", persona.IdProvinciaFK);
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPersona,Nombre,Apellido,FechaNacimiento,Cedula,Direccion,Celular,Telefono,Email,Sexo,FechaCreacion,IdNacionalidadFK,IdMunicipioFK,IdProvinciaFK,CreadoPor,ModificadoPor")] Persona persona)
        {
            if (id != persona.IdPersona)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.IdPersona))
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
            ViewData["IdMunicipioFK"] = new SelectList(_context.Municipios, "IdMunicipio", "IdMunicipio", persona.IdMunicipioFK);
            ViewData["IdNacionalidadFK"] = new SelectList(_context.Nacionalidades, "IdNacionalidad", "nacionalidad", persona.IdNacionalidadFK);
            ViewData["IdProvinciaFK"] = new SelectList(_context.Provincias, "IdProvincia", "IdProvincia", persona.IdProvinciaFK);
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Personas == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .Include(p => p.Municipio)
                .Include(p => p.Nacionalidad)
                .Include(p => p.Provincia)
                .FirstOrDefaultAsync(m => m.IdPersona == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Personas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Personas'  is null.");
            }
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
          return (_context.Personas?.Any(e => e.IdPersona == id)).GetValueOrDefault();
        }
    }
}
