using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyPageRazor2019_1.Models
{
    public class MyPageRazor2019_1Context : DbContext
    {
        public MyPageRazor2019_1Context (DbContextOptions<MyPageRazor2019_1Context> options)
            : base(options)
        {
        }

        public DbSet<MyPageRazor2019_1.Models.Movie> Movie { get; set; }
    }
}
