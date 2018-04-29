using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLiveScoring.Models
{
    public class Score
    {
        public Comment[] Comments { get; set; }

        [Display(Name = "Equipe 1")]
        public string LocalName { get; set; }

        [Display(Name = "Score équipe 1")]
        public int LocalScore { get; set; }

        [Display(Name = "Date du match")]
        [DataType(DataType.DateTime)]
        public DateTime MatchDate { get; set; }
        public int ScoreID { get; set; }

        [Display(Name = "Equipe 2")]
        public string VisitName { get; set; }

        [Display(Name = "Score équipe 2")]
        public int VisitScore { get; set; }
    }
}
