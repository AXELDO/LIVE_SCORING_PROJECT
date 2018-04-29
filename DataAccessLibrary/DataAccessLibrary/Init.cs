using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Context;

namespace DataAccessLibrary
{
    public static class Init
    {
        public static void Main()
        {
           var context = new CompetitionContext();
           context.Database.Initialize(true);

        }
    }
}
