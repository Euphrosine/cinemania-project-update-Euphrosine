using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CineMania.Data;
using CineMania.Models;

namespace CineMania.Pages
{
    public class ContactModel : PageModel
    {
        private readonly CineMania.Data.CinemaniaContext _context;

        public ContactModel(CineMania.Data.CinemaniaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactInfo ContactInfo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contacts.Add(ContactInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
