using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticaJigsaw.Data;
using PracticaJigsaw.Models;

namespace PracticaJigsaw.Controllers
{
    public class RompecabezasController : Controller
    {
        private readonly RompecabezasContext _context;

        public RompecabezasController(RompecabezasContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Rompecocos.ToListAsync());
        }

        public async Task<IActionResult> Busqueda(string bTema, string bSize)
        {
            var elemento = from lista in _context.Rompecocos
                           select lista;
            IQueryable<string> TemaQuery = from lista in _context.Rompecocos
                                           orderby lista.Tema
                                           select lista.Tema;
            IQueryable<string> SizeQuery = from lista in _context.Rompecocos
                                           orderby lista.Medidas
                                           select lista.Medidas;

            if (!String.IsNullOrEmpty(bTema))
            {
                elemento = elemento.Where(t => t.Tema == bTema);
            }
            if (!String.IsNullOrEmpty(bSize))
            {
                elemento = elemento.Where(c => c.Medidas == bSize);
            }

            var filtrarVm = new FiltrarVM
            {
                Jigs = await elemento.ToListAsync(),
                ListaSize = new SelectList(await SizeQuery.Distinct().ToListAsync()),
                ListaTema = new SelectList(await TemaQuery.Distinct().ToListAsync())
            };

            return View(filtrarVm);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rompecabezas = await _context.Rompecocos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rompecabezas == null)
            {
                return NotFound();
            }

            return View(rompecabezas);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumPiezas,Marca,RangoEdad,Autor,Distribuidor,Tema,Nombre,Medidas,Precio")] Rompecabezas rompecabezas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rompecabezas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rompecabezas);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rompecabezas = await _context.Rompecocos.FindAsync(id);
            if (rompecabezas == null)
            {
                return NotFound();
            }
            return View(rompecabezas);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumPiezas,Marca,RangoEdad,Autor,Distribuidor,Tema,Nombre,Medidas,Precio")] Rompecabezas rompecabezas)
        {
            if (id != rompecabezas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rompecabezas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RompecabezasExists(rompecabezas.Id))
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
            return View(rompecabezas);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rompecabezas = await _context.Rompecocos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rompecabezas == null)
            {
                return NotFound();
            }

            return View(rompecabezas);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rompecabezas = await _context.Rompecocos.FindAsync(id);
            _context.Rompecocos.Remove(rompecabezas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RompecabezasExists(int id)
        {
            return _context.Rompecocos.Any(e => e.Id == id);
        }
    }
}
