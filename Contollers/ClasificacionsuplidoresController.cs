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
    public class ClasificacionsuplidoresController : Controller
    {
        private readonly FAcTContext _context;

        public ClasificacionsuplidoresController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Clasificacionsuplidores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clasificacionsuplidores.ToListAsync());
        }

        // GET: Clasificacionsuplidores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionsuplidores = await _context.Clasificacionsuplidores
                .FirstOrDefaultAsync(m => m.ClasificacionsuplidoresID == id);
            if (clasificacionsuplidores == null)
            {
                return NotFound();
            }

            return View(clasificacionsuplidores);
        }

        // GET: Clasificacionsuplidores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clasificacionsuplidores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClasificacionsuplidoresID,Descripcion")] Clasificacionsuplidores clasificacionsuplidores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clasificacionsuplidores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificacionsuplidores);
        }

        // GET: Clasificacionsuplidores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionsuplidores = await _context.Clasificacionsuplidores.FindAsync(id);
            if (clasificacionsuplidores == null)
            {
                return NotFound();
            }
            return View(clasificacionsuplidores);
        }

        // POST: Clasificacionsuplidores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClasificacionsuplidoresID,Descripcion")] Clasificacionsuplidores clasificacionsuplidores)
        {
            if (id != clasificacionsuplidores.ClasificacionsuplidoresID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clasificacionsuplidores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClasificacionsuplidoresExists(clasificacionsuplidores.ClasificacionsuplidoresID))
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
            return View(clasificacionsuplidores);
        }

        // GET: Clasificacionsuplidores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionsuplidores = await _context.Clasificacionsuplidores
                .FirstOrDefaultAsync(m => m.ClasificacionsuplidoresID == id);
            if (clasificacionsuplidores == null)
            {
                return NotFound();
            }

            return View(clasificacionsuplidores);
        }

        // POST: Clasificacionsuplidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clasificacionsuplidores = await _context.Clasificacionsuplidores.FindAsync(id);
            _context.Clasificacionsuplidores.Remove(clasificacionsuplidores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClasificacionsuplidoresExists(int id)
        {
            return _context.Clasificacionsuplidores.Any(e => e.ClasificacionsuplidoresID == id);
        }
    }
}
