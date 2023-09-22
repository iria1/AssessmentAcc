using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssessmentAcc.Data;
using AssessmentAcc.Models;

namespace AssessmentAcc.Controllers
{
    public class ItemTransactionsController : Controller
    {
        private readonly AssessmentAccContext _context;

        public ItemTransactionsController(AssessmentAccContext context)
        {
            _context = context;
        }

        // GET: ItemTransactions
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemTransactions.ToListAsync());
        }

        // GET: ItemTransactions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemTransactions = await _context.ItemTransactions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemTransactions == null)
            {
                return NotFound();
            }

            return View(itemTransactions);
        }

        // GET: ItemTransactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemTransactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TransaksiId,Jumlah,Nama,Satuan")] ItemTransactions itemTransactions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemTransactions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemTransactions);
        }

        // GET: ItemTransactions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemTransactions = await _context.ItemTransactions.FindAsync(id);
            if (itemTransactions == null)
            {
                return NotFound();
            }
            return View(itemTransactions);
        }

        // POST: ItemTransactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,TransaksiId,Jumlah,Nama,Satuan")] ItemTransactions itemTransactions)
        {
            if (id != itemTransactions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemTransactions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemTransactionsExists(itemTransactions.Id))
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
            return View(itemTransactions);
        }

        // GET: ItemTransactions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemTransactions = await _context.ItemTransactions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemTransactions == null)
            {
                return NotFound();
            }

            return View(itemTransactions);
        }

        // POST: ItemTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var itemTransactions = await _context.ItemTransactions.FindAsync(id);
            _context.ItemTransactions.Remove(itemTransactions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemTransactionsExists(long id)
        {
            return _context.ItemTransactions.Any(e => e.Id == id);
        }
    }
}
