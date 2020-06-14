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
    public class SuplidoresController : Controller
    {
        private readonly FAcTContext _context;

        public SuplidoresController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Suplidores
        public async Task<IActionResult> Index()
        {
            var fAcTContext = _context.Suplidores.Include(s => s.Clasificacionsuplidores);
            return View(await fAcTContext.ToListAsync());
        }

        // GET: Suplidores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidores = await _context.Suplidores
                .Include(s => s.Clasificacionsuplidores)
                .FirstOrDefaultAsync(m => m.SuplidoresID == id);
            if (suplidores == null)
            {
                return NotFound();
            }

            return View(suplidores);
        }

        // GET: Suplidores/Create
        public IActionResult Create()
        {
            ViewData["ClasificacionsuplidoresID"] = new SelectList(_context.Clasificacionsuplidores, "ClasificacionsuplidoresID", "Descripcion");
            return View();
        }

        // POST: Suplidores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuplidoresID,nombre,Direccion,Telefono,Correo,ClasificacionsuplidoresID")] Suplidores suplidores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suplidores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClasificacionsuplidoresID"] = new SelectList(_context.Clasificacionsuplidores, "ClasificacionsuplidoresID", "Descripcion", suplidores.ClasificacionsuplidoresID);
            return View(suplidores);
        }

        // GET: Suplidores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidores = await _context.Suplidores.FindAsync(id);
            if (suplidores == null)
            {
                return NotFound();
            }
            ViewData["ClasificacionsuplidoresID"] = new SelectList(_context.Clasificacionsuplidores, "ClasificacionsuplidoresID", "Descripcion", suplidores.ClasificacionsuplidoresID);
            return View(suplidores);
        }

        // POST: Suplidores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SuplidoresID,nombre,Direccion,Telefono,Correo,ClasificacionsuplidoresID")] Suplidores suplidores)
        {
            if (id != suplidores.SuplidoresID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suplidores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuplidoresExists(suplidores.SuplidoresID))
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
            ViewData["ClasificacionsuplidoresID"] = new SelectList(_context.Clasificacionsuplidores, "ClasificacionsuplidoresID", "Descripcion", suplidores.ClasificacionsuplidoresID);
            return View(suplidores);
        }

        // GET: Suplidores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidores = await _context.Suplidores
                .Include(s => s.Clasificacionsuplidores)
                .FirstOrDefaultAsync(m => m.SuplidoresID == id);
            if (suplidores == null)
            {
                return NotFound();
            }

            return View(suplidores);
        }

        // POST: Suplidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suplidores = await _context.Suplidores.FindAsync(id);
            _context.Suplidores.Remove(suplidores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuplidoresExists(int id)
        {
            return _context.Suplidores.Any(e => e.SuplidoresID == id);
        }
    }
}
