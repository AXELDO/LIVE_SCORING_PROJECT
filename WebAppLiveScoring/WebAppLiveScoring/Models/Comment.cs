using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLiveScoring.Models
{
    
    public enum CommentType
    {
        StartMatch,
        Action,
        Corner,
        Penalty,
        Goal,
        YellowCard,
        RedCard,
        EndMatch
    }
    public class Comment
    {
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }
        public int CommentType { get; set; }
        public int ID { get; set; }
        public int ScoreID { get; set; }
    }
}
