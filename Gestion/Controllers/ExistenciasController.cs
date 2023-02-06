using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gestion.Datos;
using Gestion.Datos.Entidades;

namespace Gestion.Controllers
{
    public class ExistenciasController : Controller
    {
        private readonly DataContext _context;

        public ExistenciasController(DataContext context)
        {
            _context = context;
        }

        // GET: Existencias
        public async Task<IActionResult> Index()
        {
              return _context.Existencias != null ? 
                          View(await _context.Existencias.ToListAsync()) :
                          Problem("Entity set 'DataContext.Existencias'  is null.");
        }

        // GET: Existencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Existencias == null)
            {
                return NotFound();
            }

            var existencia = await _context.Existencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (existencia == null)
            {
                return NotFound();
            }

            return View(existencia);
        }

        // GET: Existencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Existencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CEntra,CSale,Saldo,ProductoId")] Existencia existencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(existencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(existencia);
        }

        // GET: Existencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Existencias == null)
            {
                return NotFound();
            }

            var existencia = await _context.Existencias.FindAsync(id);
            if (existencia == null)
            {
                return NotFound();
            }
            return View(existencia);
        }

        // POST: Existencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CEntra,CSale,Saldo,ProductoId")] Existencia existencia)
        {
            if (id != existencia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(existencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExistenciaExists(existencia.Id))
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
            return View(existencia);
        }

        // GET: Existencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Existencias == null)
            {
                return NotFound();
            }

            var existencia = await _context.Existencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (existencia == null)
            {
                return NotFound();
            }

            return View(existencia);
        }

        // POST: Existencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Existencias == null)
            {
                return Problem("Entity set 'DataContext.Existencias'  is null.");
            }
            var existencia = await _context.Existencias.FindAsync(id);
            if (existencia != null)
            {
                _context.Existencias.Remove(existencia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExistenciaExists(int id)
        {
          return (_context.Existencias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
