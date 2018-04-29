using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
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
        public int ID { get; set; }

        public DateTime CommentDate { get; set; }

        public CommentType ? CommentType { get; set; }

        public string CommentText { get; set; }

        public int ScoreID { get; set; }
    }
}
