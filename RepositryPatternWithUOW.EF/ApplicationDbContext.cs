using Microsoft.EntityFrameworkCore;
using RepositryPatternWithUOW.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositryPatternWithUOW.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
