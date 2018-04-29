using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLibrary.Models;
using System.Runtime.Serialization;

namespace WcfServiceLiveScoring.DataContract
{
    public class CommentDataContract
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public DateTime CommentDate { get; set; }

        [DataMember]
        public CommentType CommentType { get; set; }

        [DataMember]
        public string CommentText { get; set; }

        [DataMember]
        public int ScoreID { get; set; }
    }
}