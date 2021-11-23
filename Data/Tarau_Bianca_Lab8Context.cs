using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarau_Bianca_Lab8.Models;

namespace Tarau_Bianca_Lab8.Data
{
    public class Tarau_Bianca_Lab8Context : DbContext
    {
        public Tarau_Bianca_Lab8Context (DbContextOptions<Tarau_Bianca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tarau_Bianca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tarau_Bianca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Tarau_Bianca_Lab8.Models.Category> Category { get; set; }
    }
}
