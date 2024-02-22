using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StrideSync.Data;

namespace StrideSync.Controllers
{
    public class RunsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RunsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Runs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Runs.ToListAsync());
        }

        // GET: Runs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var run = await _context.Runs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (run == null)
            {
                return NotFound();
            }

            return View(run);
        }

        // GET: Runs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Runs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Distance,Time")] Run run)
        {
            if (ModelState.IsValid)
            {
                _context.Add(run);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(run);
        }

        // GET: Runs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var run = await _context.Runs.FindAsync(id);
            if (run == null)
            {
                return NotFound();
            }
            return View(run);
        }

        // POST: Runs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Distance,Time")] Run run)
        {
            if (id != run.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(run);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RunExists(run.Id))
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
            return View(run);
        }

        // GET: Runs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var run = await _context.Runs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (run == null)
            {
                return NotFound();
            }

            return View(run);
        }

        // POST: Runs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var run = await _context.Runs.FindAsync(id);
            if (run != null)
            {
                _context.Runs.Remove(run);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RunExists(int id)
        {
            return _context.Runs.Any(e => e.Id == id);
        }
    }
}
