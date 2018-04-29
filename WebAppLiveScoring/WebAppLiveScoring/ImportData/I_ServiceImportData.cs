using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppLiveScoring.Models;

namespace WebAppLiveScoring.ImportData
{
    public interface  I_ServiceImportData
    {
        List<Score> GetAllScores();

        List<Score> GetScoresOfDay();

        List<Score> GetScoresOfMonth();

        List<Score> GetScoresOfWeek();

        List<Score> GetLiveScores();

        List<Score> GetScoreByCompetition(int CompetitionID);

        List<Score> GetNextScores();


    }
}
