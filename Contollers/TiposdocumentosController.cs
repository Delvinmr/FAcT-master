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
    public class TiposdocumentosController : Controller
    {
        private readonly FAcTContext _context;

        public TiposdocumentosController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Tiposdocumentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tiposdocumentos.ToListAsync());
        }

        // GET: Tiposdocumentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposdocumentos = await _context.Tiposdocumentos
                .FirstOrDefaultAsync(m => m.tiposdocumentosID == id);
            if (tiposdocumentos == null)
            {
                return NotFound();
            }

            return View(tiposdocumentos);
        }

        // GET: Tiposdocumentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tiposdocumentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("tiposdocumentosID,Descripcion")] Tiposdocumentos tiposdocumentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tiposdocumentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tiposdocumentos);
        }

        // GET: Tiposdocumentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposdocumentos = await _context.Tiposdocumentos.FindAsync(id);
            if (tiposdocumentos == null)
            {
                return NotFound();
            }
            return View(tiposdocumentos);
        }

        // POST: Tiposdocumentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("tiposdocumentosID,Descripcion")] Tiposdocumentos tiposdocumentos)
        {
            if (id != tiposdocumentos.tiposdocumentosID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiposdocumentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiposdocumentosExists(tiposdocumentos.tiposdocumentosID))
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
            return View(tiposdocumentos);
        }

        // GET: Tiposdocumentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposdocumentos = await _context.Tiposdocumentos
                .FirstOrDefaultAsync(m => m.tiposdocumentosID == id);
            if (tiposdocumentos == null)
            {
                return NotFound();
            }

            return View(tiposdocumentos);
        }

        // POST: Tiposdocumentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tiposdocumentos = await _context.Tiposdocumentos.FindAsync(id);
            _context.Tiposdocumentos.Remove(tiposdocumentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiposdocumentosExists(int id)
        {
            return _context.Tiposdocumentos.Any(e => e.tiposdocumentosID == id);
        }
    }
}
