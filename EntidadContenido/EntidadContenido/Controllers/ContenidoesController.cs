using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntidadContenido.Data;
using EntidadContenido.Models;

namespace EntidadContenido.Controllers
{
    public class ContenidoesController : Controller
    {
        private readonly EntidadContenidoContext _context;

        public ContenidoesController(EntidadContenidoContext context)
        {
            _context = context;
        }

        // GET: Contenidoes
    

        public async Task<IActionResult> Index(string searchString)
        {   
            var contenido = from c in _context.Contenido
                         select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                contenido = contenido.Where(s => s.Categoria.Equals(searchString));//Contains(searchString));
            }

            return View(await contenido.ToListAsync());
        }



        // GET: Contenidoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenido = await _context.Contenido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contenido == null)
            {
                return NotFound();
            }

            return View(contenido);
        }

        // GET: Contenidoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contenidoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Autor,Descripcion,Categoria,TipoContendio,FechaPublicacion")] Contenido contenido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contenido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contenido);
        }

        // GET: Contenidoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenido = await _context.Contenido.FindAsync(id);
            if (contenido == null)
            {
                return NotFound();
            }
            return View(contenido);
        }

        // POST: Contenidoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Autor,Descripcion,Categoria,TipoContendio,FechaPublicacion")] Contenido contenido)
        {
            if (id != contenido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contenido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContenidoExists(contenido.Id))
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
            return View(contenido);
        }

        // GET: Contenidoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenido = await _context.Contenido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contenido == null)
            {
                return NotFound();
            }

            return View(contenido);
        }

        // POST: Contenidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contenido = await _context.Contenido.FindAsync(id);
            _context.Contenido.Remove(contenido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContenidoExists(int id)
        {
            return _context.Contenido.Any(e => e.Id == id);
        }
    }
}
