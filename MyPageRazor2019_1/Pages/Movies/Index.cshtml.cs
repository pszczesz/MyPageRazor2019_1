﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPageRazor2019_1.Models;

namespace MyPageRazor2019_1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyPageRazor2019_1.Models.MyPageRazor2019_1Context _context;

        public IndexModel(MyPageRazor2019_1.Models.MyPageRazor2019_1Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
