using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesItems.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsyWagonLestes.Pages.ItemsPage
{
    public class IndexModel : PageModel
    {
        private readonly PsyWagonLestes.Data.PsyWagonLestesContext _context;

        public IndexModel(PsyWagonLestes.Data.PsyWagonLestesContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get; set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}