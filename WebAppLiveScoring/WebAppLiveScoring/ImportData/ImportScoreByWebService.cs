using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppLiveScoring.Models;
using Newtonsoft.Json;
using WebAppLiveScoring.Helpers;

namespace WebAppLiveScoring.ImportData
{
    public  class ImportScoreByWebService : I_ServiceImportData
    {

       public List<Score> GetAllScores()
        {
            string JsonData = ServiceCaller.GetJsonDataFromUrl("http://localhost:54513/ServiceLiveScoring/ScoreService/GetAllScores/");

            List<Score> list = ConvertData.ConvertJsonDataToObject<Score>(JsonData) ;
            
            return list;
        }

        public List<Score> GetScoresOfWeek()
        {
            return null;
        }
        
        public List<Score> GetScoresOfDay()
        {
            return null;
        }

        public List<Score> GetScoresOfMonth()
        {
            return null;
        }

        public List<Score> GetLiveScores()
        {
            return null;
        }

        public List<Score> GetScoreByCompetition(int CompetitionID)
        {
            return null;
        }

        public List<Score> GetNextScores()
        {
            return null;
        }
    }
}
