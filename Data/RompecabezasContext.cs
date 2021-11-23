using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticaJigsaw.Models;

namespace PracticaJigsaw.Data
{
    public class RompecabezasContext : DbContext
    {
        public RompecabezasContext(DbContextOptions<RompecabezasContext> options) : base(options) { }
        public DbSet<Rompecabezas> Rompecocos { get; set; }
    }
}
