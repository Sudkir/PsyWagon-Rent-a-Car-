﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PsyWagonLestes.Pages.Cars
{
    public class EditModel : PageModel
    {
        private readonly PsyWagonLestes.Data.PsyWagonLestesContext _context;

        public EditModel(PsyWagonLestes.Data.PsyWagonLestesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Car.FirstOrDefaultAsync(m => m.ID == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(Car.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CarExists(int id)
        {
            return _context.Car.Any(e => e.ID == id);
        }
    }
}