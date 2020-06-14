using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FAcT.Data;
using FAcT.Models;

namespace FAcT.Contollers
{
    public class ClasificaciondeArticulosController : Controller
    {
        private readonly FAcTContext _context;

        public ClasificaciondeArticulosController(FAcTContext context)
        {
            _context = context;
        }

        // GET: ClasificaciondeArticulos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClasificaciondeArticulos.ToListAsync());
        }

        // GET: ClasificaciondeArticulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificaciondeArticulos = await _context.ClasificaciondeArticulos
                .FirstOrDefaultAsync(m => m.ClasificaciondeArticulosID == id);
            if (clasificaciondeArticulos == null)
            {
                return NotFound();
            }

            return View(clasificaciondeArticulos);
        }

        // GET: ClasificaciondeArticulos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClasificaciondeArticulos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClasificaciondeArticulosID,Descripcion")] ClasificaciondeArticulos clasificaciondeArticulos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clasificaciondeArticulos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificaciondeArticulos);
        }

        // GET: ClasificaciondeArticulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificaciondeArticulos = await _context.ClasificaciondeArticulos.FindAsync(id);
            if (clasificaciondeArticulos == null)
            {
                return NotFound();
            }
            return View(clasificaciondeArticulos);
        }

        // POST: ClasificaciondeArticulos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClasificaciondeArticulosID,Descripcion")] ClasificaciondeArticulos clasificaciondeArticulos)
        {
            if (id != clasificaciondeArticulos.ClasificaciondeArticulosID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clasificaciondeArticulos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClasificaciondeArticulosExists(clasificaciondeArticulos.ClasificaciondeArticulosID))
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
            return View(clasificaciondeArticulos);
        }

        // GET: ClasificaciondeArticulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificaciondeArticulos = await _context.ClasificaciondeArticulos
                .FirstOrDefaultAsync(m => m.ClasificaciondeArticulosID == id);
            if (clasificaciondeArticulos == null)
            {
                return NotFound();
            }

            return View(clasificaciondeArticulos);
        }

        // POST: ClasificaciondeArticulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clasificaciondeArticulos = await _context.ClasificaciondeArticulos.FindAsync(id);
            _context.ClasificaciondeArticulos.Remove(clasificaciondeArticulos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClasificaciondeArticulosExists(int id)
        {
            return _context.ClasificaciondeArticulos.Any(e => e.ClasificaciondeArticulosID == id);
        }
    }
}
