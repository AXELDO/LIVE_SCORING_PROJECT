using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public enum CompetitionType
    {
        ChampionsLeague,
        UEFACup,
        WorldCup
    }
    public class Competition
    {  
        public int CompetitionID { get; set; }

        public string CompetitionName { get; set; }

        public DateTime CompetitionDate { get; set; }

        public CompetitionType? CompetitionType { get; set; }

        public virtual ICollection<Score> Scores { get; set; }

    }
}
