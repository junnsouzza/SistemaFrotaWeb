using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrotaSisWeb.Models.SisModels;

namespace FrotaSisWeb.Controllers
{
    public class SisMarcasController : Controller
    {
        private readonly G3DBSContext _context;

        public SisMarcasController(G3DBSContext context)
        {
            _context = context;
        }

        // GET: SisMarcas
        public async Task<IActionResult> Index()
        {
            return View(await _context.SisMarcas.ToListAsync());
        }

        // GET: SisMarcas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sisMarcas = await _context.SisMarcas
                .FirstOrDefaultAsync(m => m.IdMarca == id);
            if (sisMarcas == null)
            {
                return NotFound();
            }

            return PartialView(sisMarcas);
        }      

        // GET: SisMarcas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SisMarcas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMarca,DescMarca,Usacadmat,Usacadveic,Ativo")] SisMarcas sisMarcas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sisMarcas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sisMarcas);
        }

        // GET: SisMarcas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sisMarcas = await _context.SisMarcas.FindAsync(id);
            if (sisMarcas == null)
            {
                return NotFound();
            }
            return View(sisMarcas);
        }

        // POST: SisMarcas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMarca,DescMarca,Usacadmat,Usacadveic,Ativo")] SisMarcas sisMarcas)
        {
            if (id != sisMarcas.IdMarca)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sisMarcas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SisMarcasExists(sisMarcas.IdMarca))
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
            return View(sisMarcas);
        }

        // GET: SisMarcas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sisMarcas = await _context.SisMarcas
                .FirstOrDefaultAsync(m => m.IdMarca == id);
            if (sisMarcas == null)
            {
                return NotFound();
            }

            return PartialView(sisMarcas);
        }

        // POST: SisMarcas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sisMarcas = await _context.SisMarcas.FindAsync(id);
            _context.SisMarcas.Remove(sisMarcas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SisMarcasExists(int id)
        {
            return _context.SisMarcas.Any(e => e.IdMarca == id);
        }
    }
}
