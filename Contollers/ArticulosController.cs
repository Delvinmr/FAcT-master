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
    public class ArticulosController : Controller
    {
        private readonly FAcTContext _context;

        public ArticulosController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Articulos
        public async Task<IActionResult> Index()
        {
            var fAcTContext = _context.Articulos.Include(a => a.ClasificaciondeArticulos).Include(a => a.Status).Include(a => a.marca).Include(a => a.ubicacion).Include(a => a.unidaddemedidas);
            return View(await fAcTContext.ToListAsync());
        }

        // GET: Articulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulos = await _context.Articulos
                .Include(a => a.ClasificaciondeArticulos)
                .Include(a => a.Status)
                .Include(a => a.marca)
                .Include(a => a.ubicacion)
                .Include(a => a.unidaddemedidas)
                .FirstOrDefaultAsync(m => m.articulosID == id);
            if (articulos == null)
            {
                return NotFound();
            }

            return View(articulos);
        }

        // GET: Articulos/Create
        public IActionResult Create()
        {
            ViewData["ClasificaciondeArticulosID"] = new SelectList(_context.ClasificaciondeArticulos, "ClasificaciondeArticulosID", "Descripcion");
            ViewData["statusID"] = new SelectList(_context.Status, "statusID", "Descripcion");
            ViewData["marcaID"] = new SelectList(_context.Marca, "marcaID", "Descripcion");
            ViewData["ubicacionID"] = new SelectList(_context.Ubicacion, "ubicacionID", "Descripcion");
            ViewData["unidaddemedidasID"] = new SelectList(_context.Unidaddemedidas, "unidaddemedidasID", "Descripcion");
            return View();
        }

        // POST: Articulos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("articulosID,Descripcion,Precio,unidaddemedidasID,marcaID,ClasificaciondeArticulosID,ubicacionID,statusID")] Articulos articulos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(articulos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClasificaciondeArticulosID"] = new SelectList(_context.ClasificaciondeArticulos, "ClasificaciondeArticulosID", "Descripcion", articulos.ClasificaciondeArticulosID);
            ViewData["statusID"] = new SelectList(_context.Status, "statusID", "Descripcion", articulos.statusID);
            ViewData["marcaID"] = new SelectList(_context.Marca, "marcaID", "Descripcion", articulos.marcaID);
            ViewData["ubicacionID"] = new SelectList(_context.Ubicacion, "ubicacionID", "Descripcion", articulos.ubicacionID);
            ViewData["unidaddemedidasID"] = new SelectList(_context.Unidaddemedidas, "unidaddemedidasID", "Descripcion", articulos.unidaddemedidasID);
            return View(articulos);
        }

        // GET: Articulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulos = await _context.Articulos.FindAsync(id);
            if (articulos == null)
            {
                return NotFound();
            }
            ViewData["ClasificaciondeArticulosID"] = new SelectList(_context.ClasificaciondeArticulos, "ClasificaciondeArticulosID", "Descripcion", articulos.ClasificaciondeArticulosID);
            ViewData["statusID"] = new SelectList(_context.Status, "statusID", "Descripcion", articulos.statusID);
            ViewData["marcaID"] = new SelectList(_context.Marca, "marcaID", "Descripcion", articulos.marcaID);
            ViewData["ubicacionID"] = new SelectList(_context.Ubicacion, "ubicacionID", "Descripcion", articulos.ubicacionID);
            ViewData["unidaddemedidasID"] = new SelectList(_context.Unidaddemedidas, "unidaddemedidasID", "Descripcion", articulos.unidaddemedidasID);
            return View(articulos);
        }

        // POST: Articulos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("articulosID,Descripcion,Precio,unidaddemedidasID,marcaID,ClasificaciondeArticulosID,ubicacionID,statusID")] Articulos articulos)
        {
            if (id != articulos.articulosID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articulos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticulosExists(articulos.articulosID))
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
            ViewData["ClasificaciondeArticulosID"] = new SelectList(_context.ClasificaciondeArticulos, "ClasificaciondeArticulosID", "Descripcion", articulos.ClasificaciondeArticulosID);
            ViewData["statusID"] = new SelectList(_context.Status, "statusID", "Descripcion", articulos.statusID);
            ViewData["marcaID"] = new SelectList(_context.Marca, "marcaID", "Descripcion", articulos.marcaID);
            ViewData["ubicacionID"] = new SelectList(_context.Ubicacion, "ubicacionID", "Descripcion", articulos.ubicacionID);
            ViewData["unidaddemedidasID"] = new SelectList(_context.Unidaddemedidas, "unidaddemedidasID", "Descripcion", articulos.unidaddemedidasID);
            return View(articulos);
        }

        // GET: Articulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulos = await _context.Articulos
                .Include(a => a.ClasificaciondeArticulos)
                .Include(a => a.Status)
                .Include(a => a.marca)
                .Include(a => a.ubicacion)
                .Include(a => a.unidaddemedidas)
                .FirstOrDefaultAsync(m => m.articulosID == id);
            if (articulos == null)
            {
                return NotFound();
            }

            return View(articulos);
        }

        // POST: Articulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var articulos = await _context.Articulos.FindAsync(id);
            _context.Articulos.Remove(articulos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticulosExists(int id)
        {
            return _context.Articulos.Any(e => e.articulosID == id);
        }
    }
}
