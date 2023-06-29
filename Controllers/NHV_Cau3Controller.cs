using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiThi_NHV.Models;

namespace BaiThi_NHV.Controllers
{
    public class NHV_Cau3Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public NHV_Cau3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NHV_Cau3
        public async Task<IActionResult> Index()
        {
              return _context.NHV_Cau3 != null ? 
                          View(await _context.NHV_Cau3.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NHV_Cau3'  is null.");
        }

        // GET: NHV_Cau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NHV_Cau3 == null)
            {
                return NotFound();
            }

            var nHV_Cau3 = await _context.NHV_Cau3
                .FirstOrDefaultAsync(m => m.NHVMaSV == id);
            if (nHV_Cau3 == null)
            {
                return NotFound();
            }

            return View(nHV_Cau3);
        }

        // GET: NHV_Cau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NHV_Cau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NHVMaSV,NHVTenSV,NHVSDT")] NHV_Cau3 nHV_Cau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nHV_Cau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nHV_Cau3);
        }

        // GET: NHV_Cau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NHV_Cau3 == null)
            {
                return NotFound();
            }

            var nHV_Cau3 = await _context.NHV_Cau3.FindAsync(id);
            if (nHV_Cau3 == null)
            {
                return NotFound();
            }
            return View(nHV_Cau3);
        }

        // POST: NHV_Cau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NHVMaSV,NHVTenSV,NHVSDT")] NHV_Cau3 nHV_Cau3)
        {
            if (id != nHV_Cau3.NHVMaSV)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nHV_Cau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NHV_Cau3Exists(nHV_Cau3.NHVMaSV))
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
            return View(nHV_Cau3);
        }

        // GET: NHV_Cau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NHV_Cau3 == null)
            {
                return NotFound();
            }

            var nHV_Cau3 = await _context.NHV_Cau3
                .FirstOrDefaultAsync(m => m.NHVMaSV == id);
            if (nHV_Cau3 == null)
            {
                return NotFound();
            }

            return View(nHV_Cau3);
        }

        // POST: NHV_Cau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NHV_Cau3 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NHV_Cau3'  is null.");
            }
            var nHV_Cau3 = await _context.NHV_Cau3.FindAsync(id);
            if (nHV_Cau3 != null)
            {
                _context.NHV_Cau3.Remove(nHV_Cau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NHV_Cau3Exists(string id)
        {
          return (_context.NHV_Cau3?.Any(e => e.NHVMaSV == id)).GetValueOrDefault();
        }
    }
}
