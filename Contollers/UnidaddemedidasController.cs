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
    public class UnidaddemedidasController : Controller
    {
        private readonly FAcTContext _context;

        public UnidaddemedidasController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Unidaddemedidas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Unidaddemedidas.ToListAsync());
        }

        // GET: Unidaddemedidas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidaddemedidas = await _context.Unidaddemedidas
                .FirstOrDefaultAsync(m => m.unidaddemedidasID == id);
            if (unidaddemedidas == null)
            {
                return NotFound();
            }

            return View(unidaddemedidas);
        }

        // GET: Unidaddemedidas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Unidaddemedidas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("unidaddemedidasID,Descripcion")] Unidaddemedidas unidaddemedidas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unidaddemedidas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unidaddemedidas);
        }

        // GET: Unidaddemedidas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidaddemedidas = await _context.Unidaddemedidas.FindAsync(id);
            if (unidaddemedidas == null)
            {
                return NotFound();
            }
            return View(unidaddemedidas);
        }

        // POST: Unidaddemedidas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("unidaddemedidasID,Descripcion")] Unidaddemedidas unidaddemedidas)
        {
            if (id != unidaddemedidas.unidaddemedidasID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unidaddemedidas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnidaddemedidasExists(unidaddemedidas.unidaddemedidasID))
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
            return View(unidaddemedidas);
        }

        // GET: Unidaddemedidas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidaddemedidas = await _context.Unidaddemedidas
                .FirstOrDefaultAsync(m => m.unidaddemedidasID == id);
            if (unidaddemedidas == null)
            {
                return NotFound();
            }

            return View(unidaddemedidas);
        }

        // POST: Unidaddemedidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unidaddemedidas = await _context.Unidaddemedidas.FindAsync(id);
            _context.Unidaddemedidas.Remove(unidaddemedidas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnidaddemedidasExists(int id)
        {
            return _context.Unidaddemedidas.Any(e => e.unidaddemedidasID == id);
        }
    }
}
