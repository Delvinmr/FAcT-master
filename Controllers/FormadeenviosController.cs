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
    public class FormadeenviosController : Controller
    {
        private readonly FAcTContext _context;

        public FormadeenviosController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Formadeenvios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formadeenvio.ToListAsync());
        }

        // GET: Formadeenvios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formadeenvio = await _context.Formadeenvio
                .FirstOrDefaultAsync(m => m.formadeenvioID == id);
            if (formadeenvio == null)
            {
                return NotFound();
            }

            return View(formadeenvio);
        }

        // GET: Formadeenvios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formadeenvios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("formadeenvioID,Codigo,Descripcion")] Formadeenvio formadeenvio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formadeenvio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formadeenvio);
        }

        // GET: Formadeenvios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formadeenvio = await _context.Formadeenvio.FindAsync(id);
            if (formadeenvio == null)
            {
                return NotFound();
            }
            return View(formadeenvio);
        }

        // POST: Formadeenvios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("formadeenvioID,Codigo,Descripcion")] Formadeenvio formadeenvio)
        {
            if (id != formadeenvio.formadeenvioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formadeenvio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormadeenvioExists(formadeenvio.formadeenvioID))
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
            return View(formadeenvio);
        }

        // GET: Formadeenvios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formadeenvio = await _context.Formadeenvio
                .FirstOrDefaultAsync(m => m.formadeenvioID == id);
            if (formadeenvio == null)
            {
                return NotFound();
            }

            return View(formadeenvio);
        }

        // POST: Formadeenvios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formadeenvio = await _context.Formadeenvio.FindAsync(id);
            _context.Formadeenvio.Remove(formadeenvio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormadeenvioExists(int id)
        {
            return _context.Formadeenvio.Any(e => e.formadeenvioID == id);
        }
    }
}
