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
    public class EmpleadoesController : Controller
    {
        private readonly FAcTContext _context;

        public EmpleadoesController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Empleadoes
        public async Task<IActionResult> Index()
        {
            var fAcTContext = _context.Empleado.Include(e => e.Empresa).Include(e => e.Puestodetrabajo).Include(e => e.tiposdocumentos);
            return View(await fAcTContext.ToListAsync());
        }

        // GET: Empleadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado
                .Include(e => e.Empresa)
                .Include(e => e.Puestodetrabajo)
                .Include(e => e.tiposdocumentos)
                .FirstOrDefaultAsync(m => m.empleadoID == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: Empleadoes/Create
        public IActionResult Create()
        {
            ViewData["empresaID"] = new SelectList(_context.Empresa, "empresaID", "Descripcion");
            ViewData["PuestodetrabajoID"] = new SelectList(_context.Puestodetrabajo, "PuestodetrabajoID", "Descripcion");
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion");
            return View();
        }

        // POST: Empleadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("empleadoID,nombre,apellidos,tiposdocumentosID,Documento,Direccion,Telefono,Celular,Correo,empresaID,PuestodetrabajoID")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["empresaID"] = new SelectList(_context.Empresa, "empresaID", "Descripcion", empleado.empresaID);
            ViewData["PuestodetrabajoID"] = new SelectList(_context.Puestodetrabajo, "PuestodetrabajoID", "Descripcion", empleado.PuestodetrabajoID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", empleado.tiposdocumentosID);
            return View(empleado);
        }

        // GET: Empleadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            ViewData["empresaID"] = new SelectList(_context.Empresa, "empresaID", "Descripcion", empleado.empresaID);
            ViewData["PuestodetrabajoID"] = new SelectList(_context.Puestodetrabajo, "PuestodetrabajoID", "Descripcion", empleado.PuestodetrabajoID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", empleado.tiposdocumentosID);
            return View(empleado);
        }

        // POST: Empleadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("empleadoID,nombre,apellidos,tiposdocumentosID,Documento,Direccion,Telefono,Celular,Correo,empresaID,PuestodetrabajoID")] Empleado empleado)
        {
            if (id != empleado.empleadoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpleadoExists(empleado.empleadoID))
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
            ViewData["empresaID"] = new SelectList(_context.Empresa, "empresaID", "Descripcion", empleado.empresaID);
            ViewData["PuestodetrabajoID"] = new SelectList(_context.Puestodetrabajo, "PuestodetrabajoID", "Descripcion", empleado.PuestodetrabajoID);
            ViewData["tiposdocumentosID"] = new SelectList(_context.Tiposdocumentos, "tiposdocumentosID", "Descripcion", empleado.tiposdocumentosID);
            return View(empleado);
        }

        // GET: Empleadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado
                .Include(e => e.Empresa)
                .Include(e => e.Puestodetrabajo)
                .Include(e => e.tiposdocumentos)
                .FirstOrDefaultAsync(m => m.empleadoID == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // POST: Empleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleado = await _context.Empleado.FindAsync(id);
            _context.Empleado.Remove(empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleado.Any(e => e.empleadoID == id);
        }
    }
}
