using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PsyWagonLestes.Data;
using RazorPagesMovie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PsyWagonLestes.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly PsyWagonLestes.Data.PsyWagonLestesContext _context;

        public IndexModel(PsyWagonLestes.Data.PsyWagonLestesContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }    //Поиск на странице

        public SelectList Brands { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CarBrand { get; set; }

        public async Task OnGetAsync()
        {
            // Car = await _context.Car.ToListAsync(); дефолтная строка

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Car
                                            orderby m.Brand
                                            select m.Brand;

            var cars = from c in _context.Car
                       select c;// using System.Linq;
            if (!string.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(s => s.Name.Contains(SearchString));//Модель
            }

            if (!string.IsNullOrEmpty(CarBrand))
            {
                cars = cars.Where(x => x.Brand == CarBrand);//Марка
            }
            Brands = new SelectList(await genreQuery.Distinct().ToListAsync());

            Car = await cars.ToListAsync();
        }
    }
}