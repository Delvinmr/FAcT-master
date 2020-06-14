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
    public class VendedoresController : Controller
    {
        private readonly FAcTContext _context;

        public VendedoresController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Vendedores
        public async Task<IActionResult> Index()
        {
            var fAcTContext = _context.Vendedores.Include(v => v.Suplidores).Include(v => v.tiposdocumentos);
            return View(await fAcTContext.ToListAsync());
        }

        // GET: Vendedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedores = await _context.Vendedores
                .Include(v => v.Suplidores)
                .Include(v => v.tiposdocumentos)
                .FirstOrDefaultAsync(m => m.vendedorID == id);
            if (vendedores == null)
            {
                return NotFound();
            }

            return View(vendedores);
        }

        // GET: Vendedores/Create
        public IActionResult Create()
        {
            ViewData["SuplidoresID"] = new SelectList(_context.Suplidores, "SuplidoresID", "Correo");
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion");
            return View();
        }

        // POST: Vendedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("vendedorID,nombre,apellidos,tiposdocumentosID,Documento,Direccion,Telefono,Celular,Correo,SuplidoresID")] Vendedores vendedores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendedores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SuplidoresID"] = new SelectList(_context.Suplidores, "SuplidoresID", "Correo", vendedores.SuplidoresID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", vendedores.tiposdocumentosID);
            return View(vendedores);
        }

        // GET: Vendedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedores = await _context.Vendedores.FindAsync(id);
            if (vendedores == null)
            {
                return NotFound();
            }
            ViewData["SuplidoresID"] = new SelectList(_context.Suplidores, "SuplidoresID", "Correo", vendedores.SuplidoresID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", vendedores.tiposdocumentosID);
            return View(vendedores);
        }

        // POST: Vendedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("vendedorID,nombre,apellidos,tiposdocumentosID,Documento,Direccion,Telefono,Celular,Correo,SuplidoresID")] Vendedores vendedores)
        {
            if (id != vendedores.vendedorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendedores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendedoresExists(vendedores.vendedorID))
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
            ViewData["SuplidoresID"] = new SelectList(_context.Suplidores, "SuplidoresID", "Correo", vendedores.SuplidoresID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", vendedores.tiposdocumentosID);
            return View(vendedores);
        }

        // GET: Vendedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendedores = await _context.Vendedores
                .Include(v => v.Suplidores)
                .Include(v => v.tiposdocumentos)
                .FirstOrDefaultAsync(m => m.vendedorID == id);
            if (vendedores == null)
            {
                return NotFound();
            }

            return View(vendedores);
        }

        // POST: Vendedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendedores = await _context.Vendedores.FindAsync(id);
            _context.Vendedores.Remove(vendedores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendedoresExists(int id)
        {
            return _context.Vendedores.Any(e => e.vendedorID == id);
        }
    }
}
