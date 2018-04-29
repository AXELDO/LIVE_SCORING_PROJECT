using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //using (var context = new TacheContext(serviceProvider.GetRequiredService<DbContextOptions<TacheContext>>()))
            //{
            //    // Look for any tache
            //    if (context.Tache.Any())
            //    {
            //        return; // DB has been seed
            //    }
            //}
        }
    }
}
