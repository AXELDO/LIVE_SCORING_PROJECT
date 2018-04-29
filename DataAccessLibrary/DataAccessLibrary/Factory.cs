using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataAccessLibrary
{
    public class Factory
    {
        private static CompetitionContext _contextData;


        private static CompetitionContext GetContextData()
        {
            if (_contextData == null)
            {
                _contextData = new CompetitionContext();
            }

            return _contextData;
        }

        /// <summary>
        /// Renvoie tous les matchs qui ont eu lieu
        /// </summary>
        /// <returns></returns>
        public static List<Score> GetAllScores()
        {
            return GetContextData().Score.ToList();
        }


        /// <summary>
        /// Renvoi toutes les competitions disponibles
        /// </summary>
        /// <returns></returns>
        public static List<Competition> GetCompetitions()
        {
            return GetContextData().Competition.ToList();
        }

        /// <summary>
        /// Renvoie toutes les competitions qui ont eu lieu par type de competions
        /// </summary>
        /// <returns></returns>
        public static List<Competition> GetCompetitionsByType(CompetitionType Type)
        {
            return GetContextData().Competition.ToList().Where(s => s.CompetitionType == Type).ToList();
        }

        /// <summary>
        /// Retourne tous les scores en direct 
        /// </summary>
        /// <returns></returns>
        public static List<Score> GetLiveScores()
        {
            return null;
        }

        /// <summary>
        /// Retourne tous les scores du jour
        /// </summary>
        /// <returns></returns>
        public static List<Score> GetScoresOfDay()
        {
            DateTime today = DateTime.Now.Date;
            return GetContextData().Score.ToList().Where(s => s.MatchDate >= today && s.MatchDate < today.AddDays(1)).ToList();
          
        }

        /// <summary>
        /// Retourne tous les scores de la semaine
        /// </summary>
        /// <returns></returns>
        public static List<Score> GetScoresOfWeek()
        {
            DateTime firstDayOfWeek = DateTime.Now.Date.AddDays(-(Convert.ToInt32(DateTime.Now.DayOfWeek) - 1));
            DateTime lastDayOfWeek = DateTime.Now.Date.AddDays(7 - Convert.ToInt32(DateTime.Now.DayOfWeek));

            return GetContextData().Score.ToList().Where(s => s.MatchDate >= firstDayOfWeek && s.MatchDate < lastDayOfWeek.AddDays(1)).ToList();           
        }

        /// <summary>
        /// Retourne tous les scores du mois
        /// </summary>
        /// <returns></returns>
        public static List<Score> GetScoresOfMonth()
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            return GetContextData().Score.ToList().Where(s => s.MatchDate >= firstDayOfMonth && s.MatchDate < lastDayOfMonth.AddDays(1)).ToList();

        }

        /// <summary>
        /// Retourne les competitions a venir
        /// </summary>
        /// <returns></returns>
        public static List<Score> GetNextScores()
        {
            return GetContextData().Score.ToList().Where(s => s.MatchDate > DateTime.Now).ToList();
            
        }

        /// <summary>
        /// Renvoie tous les scores d'une competition
        /// </summary>
        /// <param name="CompetitionID"></param>
        /// <returns></returns>
        public static List<Score> GetAllScoresByCompetition(int CompetitionID)
        {
            return GetContextData().Competition.ToList().Where(s => s.CompetitionID == CompetitionID).FirstOrDefault().Scores.ToList();
            
        }



    }
}
