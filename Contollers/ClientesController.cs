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
    public class ClientesController : Controller
    {
        private readonly FAcTContext _context;

        public ClientesController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var fAcTContext = _context.Clientes.Include(c => c.Clasificacionclientes).Include(c => c.pais).Include(c => c.provincia).Include(c => c.tiposdocumentos);
            return View(await fAcTContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .Include(c => c.Clasificacionclientes)
                .Include(c => c.pais)
                .Include(c => c.provincia)
                .Include(c => c.tiposdocumentos)
                .FirstOrDefaultAsync(m => m.clienteID == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["ClasificacionclientesID"] = new SelectList(_context.Clasificacionclientes, "ClasificacionclientesID", "Descripcion");
            ViewData["paisID"] = new SelectList(_context.Pais, "paisID", "nombre_pais");
            ViewData["provinciaID"] = new SelectList(_context.Provincia, "provinciaID", "nombre_provincia");
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("clienteID,nombre,apellidos,tiposdocumentosID,Documento,Direccion,Telefono,Celular,Correo,ClasificacionclientesID,paisID,provinciaID")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClasificacionclientesID"] = new SelectList(_context.Clasificacionclientes, "ClasificacionclientesID", "Descripcion", clientes.ClasificacionclientesID);
            ViewData["paisID"] = new SelectList(_context.Pais, "paisID", "nombre_pais", clientes.paisID);
            ViewData["provinciaID"] = new SelectList(_context.Provincia, "provinciaID", "nombre_provincia", clientes.provinciaID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", clientes.tiposdocumentosID);
            return View(clientes);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }
            ViewData["ClasificacionclientesID"] = new SelectList(_context.Clasificacionclientes, "ClasificacionclientesID", "Descripcion", clientes.ClasificacionclientesID);
            ViewData["paisID"] = new SelectList(_context.Pais, "paisID", "nombre_pais", clientes.paisID);
            ViewData["provinciaID"] = new SelectList(_context.Provincia, "provinciaID", "nombre_provincia", clientes.provinciaID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", clientes.tiposdocumentosID);
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("clienteID,nombre,apellidos,tiposdocumentosID,Documento,Direccion,Telefono,Celular,Correo,ClasificacionclientesID,paisID,provinciaID")] Clientes clientes)
        {
            if (id != clientes.clienteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientesExists(clientes.clienteID))
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
            ViewData["ClasificacionclientesID"] = new SelectList(_context.Clasificacionclientes, "ClasificacionclientesID", "Descripcion", clientes.ClasificacionclientesID);
            ViewData["paisID"] = new SelectList(_context.Pais, "paisID", "nombre_pais", clientes.paisID);
            ViewData["provinciaID"] = new SelectList(_context.Provincia, "provinciaID", "nombre_provincia", clientes.provinciaID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", clientes.tiposdocumentosID);
            return View(clientes);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .Include(c => c.Clasificacionclientes)
                .Include(c => c.pais)
                .Include(c => c.provincia)
                .Include(c => c.tiposdocumentos)
                .FirstOrDefaultAsync(m => m.clienteID == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientes = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.clienteID == id);
        }
    }
}
