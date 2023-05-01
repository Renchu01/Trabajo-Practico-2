using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrabajoPractico2.Data;
using Trabajo_Practico_2.Models;

namespace Trabajo_Practico_2.Controllers
{
    public class LibreriasController : Controller
    {
        private readonly LibrosContext _context;

        public LibreriasController(LibrosContext context)
        {
            _context = context;
        }

        // GET: Librerias
        public async Task<IActionResult> Index()
        {
              return _context.Librerias != null ? 
                          View(await _context.Librerias.ToListAsync()) :
                          Problem("Entity set 'LibrosContext.Librerias'  is null.");
        }

        // GET: Librerias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Librerias == null)
            {
                return NotFound();
            }

            var librerias = await _context.Librerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (librerias == null)
            {
                return NotFound();
            }

            return View(librerias);
        }

        // GET: Librerias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Librerias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Localidad,Direccion,Mail,Name")] Librerias librerias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(librerias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(librerias);
        }

        // GET: Librerias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Librerias == null)
            {
                return NotFound();
            }

            var librerias = await _context.Librerias.FindAsync(id);
            if (librerias == null)
            {
                return NotFound();
            }
            return View(librerias);
        }

        // POST: Librerias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Localidad,Direccion,Mail,Name")] Librerias librerias)
        {
            if (id != librerias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(librerias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibreriasExists(librerias.Id))
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
            return View(librerias);
        }

        // GET: Librerias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Librerias == null)
            {
                return NotFound();
            }

            var librerias = await _context.Librerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (librerias == null)
            {
                return NotFound();
            }

            return View(librerias);
        }

        // POST: Librerias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Librerias == null)
            {
                return Problem("Entity set 'LibrosContext.Librerias'  is null.");
            }
            var librerias = await _context.Librerias.FindAsync(id);
            if (librerias != null)
            {
                _context.Librerias.Remove(librerias);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibreriasExists(int id)
        {
          return (_context.Librerias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
