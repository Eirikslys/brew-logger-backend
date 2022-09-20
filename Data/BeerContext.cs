using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using brew_logger_backend.Models;

    public class BeerContext : DbContext
    {
        public BeerContext (DbContextOptions<BeerContext> options)
            : base(options)
        {
        }

        public DbSet<brew_logger_backend.Models.Beer> Beer { get; set; } = default!;
    }
