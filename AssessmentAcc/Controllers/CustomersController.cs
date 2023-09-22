using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssessmentAcc.Data;
using AssessmentAcc.Models;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Configuration;

namespace AssessmentAcc.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AssessmentAccContext _context;
        private readonly IConfiguration _configuration;

        public CustomersController(AssessmentAccContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipeCustomer,Nama,NomorTelp,Alamat,NomorRekening")] Customers customers)
        {
            if (await ValidatePhoneNumber(customers.NomorTelp) && ModelState.IsValid)
            {
                _context.Add(customers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customers);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return View(customers);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,TipeCustomer,Nama,NomorTelp,Alamat,NomorRekening")] Customers customers)
        {
            if (id != customers.Id)
            {
                return NotFound();
            }

            if (await ValidatePhoneNumber(customers.NomorTelp) && ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersExists(customers.Id))
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
            return View(customers);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var customers = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersExists(long id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }

        private async Task<bool> ValidatePhoneNumber(string custPhone)
        {
            var url = _configuration["PhoneNoValidator:ApiUrl"];
            var key = _configuration["PhoneNoValidator:ApiKey"];
            var phoneNo = custPhone;

            if (phoneNo.StartsWith("+62"))
            {
                phoneNo = phoneNo.Remove(0, 3);
            }
            else if (phoneNo.StartsWith("0"))
            {
                phoneNo = phoneNo.Remove(0, 1);
            }

            var validation = await url
                .SetQueryParams(new
                {
                    access_key = key,
                    number = phoneNo,
                    country_code = "ID",
                    format = 1
                })
                .GetJsonAsync<PhoneNoValidation>();

            return validation.valid;
        }
    }
}
