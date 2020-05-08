using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Meskel.Models;

namespace Meskel.Data
{
    public class MeskelContext : DbContext
    {
        public MeskelContext (DbContextOptions<MeskelContext> options)
            : base(options)
        {
        }

        public DbSet<Meskel.Models.Product> Product { get; set; }
    }
}
