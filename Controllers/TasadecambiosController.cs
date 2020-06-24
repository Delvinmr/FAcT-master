using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FAcT.Data;
using FAcT.Models;

namespace FAcT.Controllers
{
    public class TasadecambiosController : Controller
    {
        private readonly FAcTContext _context;

        public TasadecambiosController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Tasadecambios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tasadecambio.ToListAsync());
        }

        // GET: Tasadecambios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasadecambio = await _context.Tasadecambio
                .FirstOrDefaultAsync(m => m.tasadecambioID == id);
            if (tasadecambio == null)
            {
                return NotFound();
            }

            return View(tasadecambio);
        }

        // GET: Tasadecambios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasadecambios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("tasadecambioID,Codigo,Descripcion")] Tasadecambio tasadecambio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tasadecambio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tasadecambio);
        }

        // GET: Tasadecambios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasadecambio = await _context.Tasadecambio.FindAsync(id);
            if (tasadecambio == null)
            {
                return NotFound();
            }
            return View(tasadecambio);
        }

        // POST: Tasadecambios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("tasadecambioID,Codigo,Descripcion")] Tasadecambio tasadecambio)
        {
            if (id != tasadecambio.tasadecambioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tasadecambio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TasadecambioExists(tasadecambio.tasadecambioID))
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
            return View(tasadecambio);
        }

        // GET: Tasadecambios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasadecambio = await _context.Tasadecambio
                .FirstOrDefaultAsync(m => m.tasadecambioID == id);
            if (tasadecambio == null)
            {
                return NotFound();
            }

            return View(tasadecambio);
        }

        // POST: Tasadecambios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tasadecambio = await _context.Tasadecambio.FindAsync(id);
            _context.Tasadecambio.Remove(tasadecambio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TasadecambioExists(int id)
        {
            return _context.Tasadecambio.Any(e => e.tasadecambioID == id);
        }
    }
}
