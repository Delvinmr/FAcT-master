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
    public class ClasificacionclientesController : Controller
    {
        private readonly FAcTContext _context;

        public ClasificacionclientesController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Clasificacionclientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clasificacionclientes.ToListAsync());
        }

        // GET: Clasificacionclientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionclientes = await _context.Clasificacionclientes
                .FirstOrDefaultAsync(m => m.ClasificacionclientesID == id);
            if (clasificacionclientes == null)
            {
                return NotFound();
            }

            return View(clasificacionclientes);
        }

        // GET: Clasificacionclientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clasificacionclientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClasificacionclientesID,Descripcion")] Clasificacionclientes clasificacionclientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clasificacionclientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificacionclientes);
        }

        // GET: Clasificacionclientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionclientes = await _context.Clasificacionclientes.FindAsync(id);
            if (clasificacionclientes == null)
            {
                return NotFound();
            }
            return View(clasificacionclientes);
        }

        // POST: Clasificacionclientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClasificacionclientesID,Descripcion")] Clasificacionclientes clasificacionclientes)
        {
            if (id != clasificacionclientes.ClasificacionclientesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clasificacionclientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClasificacionclientesExists(clasificacionclientes.ClasificacionclientesID))
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
            return View(clasificacionclientes);
        }

        // GET: Clasificacionclientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionclientes = await _context.Clasificacionclientes
                .FirstOrDefaultAsync(m => m.ClasificacionclientesID == id);
            if (clasificacionclientes == null)
            {
                return NotFound();
            }

            return View(clasificacionclientes);
        }

        // POST: Clasificacionclientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clasificacionclientes = await _context.Clasificacionclientes.FindAsync(id);
            _context.Clasificacionclientes.Remove(clasificacionclientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClasificacionclientesExists(int id)
        {
            return _context.Clasificacionclientes.Any(e => e.ClasificacionclientesID == id);
        }
    }
}
