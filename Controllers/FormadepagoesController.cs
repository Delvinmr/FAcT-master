﻿using System;
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
    public class FormadepagoesController : Controller
    {
        private readonly FAcTContext _context;

        public FormadepagoesController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Formadepagoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formadepago.ToListAsync());
        }

        // GET: Formadepagoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formadepago = await _context.Formadepago
                .FirstOrDefaultAsync(m => m.formadepagoID == id);
            if (formadepago == null)
            {
                return NotFound();
            }

            return View(formadepago);
        }

        // GET: Formadepagoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formadepagoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("formadepagoID,Codigo,Descripcion")] Formadepago formadepago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formadepago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formadepago);
        }

        // GET: Formadepagoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formadepago = await _context.Formadepago.FindAsync(id);
            if (formadepago == null)
            {
                return NotFound();
            }
            return View(formadepago);
        }

        // POST: Formadepagoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("formadepagoID,Codigo,Descripcion")] Formadepago formadepago)
        {
            if (id != formadepago.formadepagoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formadepago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormadepagoExists(formadepago.formadepagoID))
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
            return View(formadepago);
        }

        // GET: Formadepagoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formadepago = await _context.Formadepago
                .FirstOrDefaultAsync(m => m.formadepagoID == id);
            if (formadepago == null)
            {
                return NotFound();
            }

            return View(formadepago);
        }

        // POST: Formadepagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formadepago = await _context.Formadepago.FindAsync(id);
            _context.Formadepago.Remove(formadepago);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormadepagoExists(int id)
        {
            return _context.Formadepago.Any(e => e.formadepagoID == id);
        }
    }
}
