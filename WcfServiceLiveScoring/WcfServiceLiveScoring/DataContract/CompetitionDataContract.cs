using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using DataAccessLibrary.Models;

namespace WcfServiceLiveScoring.DataContract
{
    public class CompetitionDataContract
    {
        [DataMember]
        public int CompetitionID{ get; set;}

        [DataMember]
        public string CompetitionName { get; set; }

        [DataMember]
        public DateTime CompetitionDate { get; set; }

        [DataMember]
        public CompetitionType CompetitionType { get; set; }

    }

}