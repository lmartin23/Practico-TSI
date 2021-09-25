using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContenidoApi.Models;

namespace ContenidoApi.Data
{
    public class ContenidoContext : DbContext
    {
        public ContenidoContext(DbContextOptions<ContenidoContext> options) : base(options)
        {
        }
        public DbSet<Contenido> ContenidoItems {  get; set;}
    }
}
