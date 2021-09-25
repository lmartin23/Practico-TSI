using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntidadContenido.Models;

namespace EntidadContenido.Data
{
    public class EntidadContenidoContext : DbContext
    {
        public EntidadContenidoContext (DbContextOptions<EntidadContenidoContext> options)
            : base(options)
        {
        }

        public DbSet<EntidadContenido.Models.Contenido> Contenido { get; set; }
    }
}
