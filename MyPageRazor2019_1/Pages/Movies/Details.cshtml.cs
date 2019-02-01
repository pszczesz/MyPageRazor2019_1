using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPageRazor2019_1.Models;

namespace MyPageRazor2019_1.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MyPageRazor2019_1.Models.MyPageRazor2019_1Context _context;

        public DetailsModel(MyPageRazor2019_1.Models.MyPageRazor2019_1Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
