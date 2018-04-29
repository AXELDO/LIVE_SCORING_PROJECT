using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccessLibrary.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccessLibrary.Context
{
    internal class CompetitionContext : DbContext
    {
        public CompetitionContext() : base("CompetitionDB")
        {
            

        }
        public DbSet<Competition> Competition {get;set;}

        public DbSet<Score> Score { get; set; }

        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
