using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actividades.Models;
using Actividades.Data;
namespace Actividades.Data
{
    public class DbInitializer
    {
        public static void Initializer(ActividadesContext context)
        {
            context.Database.EnsureCreated();
            if (context.periodo.Any())
            {
                return;
            }
            var periodo= new periodo[]
            {
                //
            };
            foreach (periodo a in periodo)
            {
                context.periodo.Add(a);

            }
            context.SaveChanges();
        }
    }
}
