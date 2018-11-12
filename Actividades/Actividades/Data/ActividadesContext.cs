using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Actividades.Models;

namespace Actividades.Models
{
    public class ActividadesContext : DbContext
    {
        public ActividadesContext (DbContextOptions<ActividadesContext> options)
            : base(options)
        {
        }

        public DbSet<Actividades.Models.periodo> periodo { get; set; }

        public DbSet<Actividades.Models.usuario> usuario { get; set; }
    }
}
