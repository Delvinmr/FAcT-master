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
    public class PuestodetrabajoesController : Controller
    {
        private readonly FAcTContext _context;

        public PuestodetrabajoesController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Puestodetrabajoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Puestodetrabajo.ToListAsync());
        }

        // GET: Puestodetrabajoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puestodetrabajo = await _context.Puestodetrabajo
                .FirstOrDefaultAsync(m => m.PuestodetrabajoID == id);
            if (puestodetrabajo == null)
            {
                return NotFound();
            }

            return View(puestodetrabajo);
        }

        // GET: Puestodetrabajoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Puestodetrabajoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PuestodetrabajoID,Descripcion")] Puestodetrabajo puestodetrabajo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(puestodetrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(puestodetrabajo);
        }

        // GET: Puestodetrabajoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puestodetrabajo = await _context.Puestodetrabajo.FindAsync(id);
            if (puestodetrabajo == null)
            {
                return NotFound();
            }
            return View(puestodetrabajo);
        }

        // POST: Puestodetrabajoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PuestodetrabajoID,Descripcion")] Puestodetrabajo puestodetrabajo)
        {
            if (id != puestodetrabajo.PuestodetrabajoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(puestodetrabajo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PuestodetrabajoExists(puestodetrabajo.PuestodetrabajoID))
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
            return View(puestodetrabajo);
        }

        // GET: Puestodetrabajoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puestodetrabajo = await _context.Puestodetrabajo
                .FirstOrDefaultAsync(m => m.PuestodetrabajoID == id);
            if (puestodetrabajo == null)
            {
                return NotFound();
            }

            return View(puestodetrabajo);
        }

        // POST: Puestodetrabajoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var puestodetrabajo = await _context.Puestodetrabajo.FindAsync(id);
            _context.Puestodetrabajo.Remove(puestodetrabajo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PuestodetrabajoExists(int id)
        {
            return _context.Puestodetrabajo.Any(e => e.PuestodetrabajoID == id);
        }
    }
}
