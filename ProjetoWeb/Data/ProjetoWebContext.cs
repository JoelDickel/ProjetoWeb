using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWeb.Models;

namespace ProjetoWeb.Data
{
    public class ProjetoWebContext : DbContext
    {
        public ProjetoWebContext (DbContextOptions<ProjetoWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoWeb.Models.Department> Department { get; set; }
    }
}
