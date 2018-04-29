using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MvcMovie.Models
{
    public class TacheContext : DbContext
    {
        /// <summary>
        /// Constructeur du context
        /// </summary>
        /// <param name="options"></param>
        public TacheContext() : base()
        {

        }

        /// <summary>
        /// Constructeur du context
        /// </summary>
        /// <param name="options"></param>
        public TacheContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Accesseur du context TacheContext
        /// </summary>
        public DbSet<Tache> Tache { get; set; }
    }
}
