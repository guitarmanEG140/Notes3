using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Notes.Data;
using Notes.Models;

namespace Notes.Pages.EnterNotes
{
    public class DeleteModel : PageModel
    {
        private readonly Notes.Data.NotesContext _context;

        public DeleteModel(Notes.Data.NotesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Note Note { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Note = await _context.Notes.SingleOrDefaultAsync(m => m.ID == id);

            if (Note == null)
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

            Note = await _context.Notes.FindAsync(id);

            if (Note != null)
            {
                _context.Notes.Remove(Note);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
