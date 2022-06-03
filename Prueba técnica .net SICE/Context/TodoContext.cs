using Microsoft.EntityFrameworkCore;
using Prueba_técnica_.net_SICE.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_técnica_.net_SICE.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<EstadoClass> Estado { get; set; }
        public DbSet<FabricantesClass> Fabricantes { get; set; }
        public DbSet<TerminalesClass> Terminales { get; set; }
    }
}
