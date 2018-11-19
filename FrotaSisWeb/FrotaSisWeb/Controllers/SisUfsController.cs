using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrotaSisWeb.Models.SisModels;

namespace FrotaSisWeb.Controllers
{
    public class SisUfsController : Controller
    {
        private readonly G3DBSContext _context;

        public SisUfsController(G3DBSContext context)
        {
            _context = context;
        }

        // GET: SisUfs
        public async Task<IActionResult> Index()
        {
            return View(await _context.SisUf.ToListAsync());
        }

        // GET: SisUfs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sisUf = await _context.SisUf
                .FirstOrDefaultAsync(m => m.IdUf == id);
            if (sisUf == null)
            {
                return NotFound();
            }

            return View(sisUf);
        }

        // GET: SisUfs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SisUfs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUf,DescUf")] SisUf sisUf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sisUf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sisUf);
        }

        // GET: SisUfs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sisUf = await _context.SisUf.FindAsync(id);
            if (sisUf == null)
            {
                return NotFound();
            }
            return View(sisUf);
        }

        // POST: SisUfs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdUf,DescUf")] SisUf sisUf)
        {
            if (id != sisUf.IdUf)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sisUf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SisUfExists(sisUf.IdUf))
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
            return View(sisUf);
        }

        // GET: SisUfs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sisUf = await _context.SisUf
                .FirstOrDefaultAsync(m => m.IdUf == id);
            if (sisUf == null)
            {
                return NotFound();
            }

            return View(sisUf);
        }

        // POST: SisUfs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sisUf = await _context.SisUf.FindAsync(id);
            _context.SisUf.Remove(sisUf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SisUfExists(string id)
        {
            return _context.SisUf.Any(e => e.IdUf == id);
        }
    }
}
