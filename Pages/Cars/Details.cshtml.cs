﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PsyWagonLestes.Data;
using RazorPagesMovie.Models;

namespace PsyWagonLestes.Pages.Cars
{
    public class DetailsModel : PageModel
    {
        private readonly PsyWagonLestes.Data.PsyWagonLestesContext _context;

        public DetailsModel(PsyWagonLestes.Data.PsyWagonLestesContext context)
        {
            _context = context;
        }

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
    }
}