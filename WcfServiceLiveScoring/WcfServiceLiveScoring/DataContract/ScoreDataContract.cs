using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using DataAccessLibrary.Models;
namespace WcfServiceLiveScoring
{
    [DataContract]
    public class ScoreDataContract
    {
        [DataMember]
        public DateTime MatchDate { get; set; }

        [DataMember]
        public int ScoreID { get; set; }

        [DataMember]
        public string VisitName { get; set; }

        [DataMember]
        public int VisitScore { get; set; }

        [DataMember]
        public string LocalName { get; set; }

        [DataMember]
        public int LocalScore { get; set; }

        [DataMember]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}