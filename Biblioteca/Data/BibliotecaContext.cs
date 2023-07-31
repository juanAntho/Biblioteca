using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<book> book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
         public DbSet<Models.Author> Author { get; set; } = default!;
    }
}

