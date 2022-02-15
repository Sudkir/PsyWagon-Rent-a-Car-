using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesItems.Models;
using System.Threading.Tasks;

namespace PsyWagonLestes.Pages.ItemsPage
{
    public class DeleteModel : PageModel
    {
        private readonly PsyWagonLestes.Data.PsyWagonLestesContext _context;

        public DeleteModel(PsyWagonLestes.Data.PsyWagonLestesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FirstOrDefaultAsync(m => m.ID == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FindAsync(id);

            if (Item != null)
            {
                _context.Item.Remove(Item);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}