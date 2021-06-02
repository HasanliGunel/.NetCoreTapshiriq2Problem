using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq2.Database
{
    public class AuthorContext:DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> context) : base(context) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Works> Workss { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<AuthorWorks>AuthorWorkss { get; set; }

    }
}
