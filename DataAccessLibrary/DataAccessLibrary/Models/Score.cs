using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Score
    {
        public DateTime MatchDate { get; set; }

        public int ScoreID { get; set; }

        public string VisitName { get; set; }

        public  int VisitScore { get; set; }

        public string LocalName { get; set; }

        public int LocalScore { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
