using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPageRazor2019_1.Models;

namespace MyPageRazor2019_1.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MyPageRazor2019_1.Models.MyPageRazor2019_1Context _context;

        public CreateModel(MyPageRazor2019_1.Models.MyPageRazor2019_1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}