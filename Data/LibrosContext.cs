using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabajo_Practico_2.Models;

namespace TrabajoPractico2.Data
{
    public class LibrosContext : DbContext
    {
        public LibrosContext (DbContextOptions<LibrosContext> options)
            : base(options)
        {
        }
        
        public DbSet<Trabajo_Practico_2.Models.Libros> Libros { get; set; } = default!;

        public DbSet<Trabajo_Practico_2.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<Trabajo_Practico_2.Models.Librerias> Librerias { get; set; } = default!;
    }
}
