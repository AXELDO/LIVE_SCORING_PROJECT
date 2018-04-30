using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using System.Data.Entity;

namespace DataAccessLibrary
{
    internal class CompetitionInitializer : DropCreateDatabaseAlways<CompetitionContext>
    {
        protected override void Seed(CompetitionContext context)
        {
            var comments = new List<Comment>()
            {
                new Comment(){ScoreID = 1, CommentDate= DateTime.Now,CommentType = CommentType.StartMatch, CommentText="C'est parti! Le match tant attendu entre le PSG et BARCELONE commence enfin"},
                new Comment(){ScoreID = 2, CommentDate= DateTime.Now,CommentType = CommentType.StartMatch, CommentText="C'est parti! Le match tant attendu entre le REAL MADRID et MILAN AC commence enfin"},
                new Comment(){ScoreID = 3, CommentDate=DateTime.Now,CommentType = CommentType.StartMatch, CommentText ="C'est parti! Le match tant attendu entre le FC PORTO et CHELSEA commence enfin"},
                new Comment(){ScoreID = 4, CommentDate=DateTime.Now,CommentType = CommentType.StartMatch, CommentText ="C'est parti! Le match tant attendu entre la BELGIQUE et la FRANCE commence enfin"}

            };
            comments.ForEach(s => context.Comment.Add(s));

            var ChampionsLeagueScores = new List<Score>()
            {
                new Score(){ScoreID = 1, LocalName = "PSG",VisitName="BARCELONE",MatchDate=DateTime.Now },
                new Score(){ScoreID = 2, LocalName= "REAL MADRID", VisitName="MILAN AC", MatchDate=DateTime.Now.AddMonths(1)}
            };

            ChampionsLeagueScores.ForEach(s => context.Score.Add(s));

            var UEFACupScores = new List<Score>()
            {
                  new Score(){ScoreID = 3, LocalName= "FC PORTO", VisitName="CHELSEA", MatchDate=DateTime.Now}
            };

            UEFACupScores.ForEach(s => context.Score.Add(s));

            var WorldCupScores = new List<Score>()
            {
                 new Score(){ScoreID = 4, LocalName= "BELGIQUE", VisitName="FRANCE", MatchDate=DateTime.Now}
            };

            WorldCupScores.ForEach(s => context.Score.Add(s));


            var competitions = new List<Competition>()
            {
                new Competition(){CompetitionName = "Ligue des Champions 2018", CompetitionDate = DateTime.Now, CompetitionType = CompetitionType.ChampionsLeague,Scores = ChampionsLeagueScores},
                new Competition(){CompetitionName = "Coupe UEFA 2018", CompetitionDate = DateTime.Now, CompetitionType = CompetitionType.UEFACup,Scores = UEFACupScores},
                new Competition(){CompetitionName = "Coupe du Monde 2018",  CompetitionDate = DateTime.Now, CompetitionType = CompetitionType.WorldCup,Scores = WorldCupScores},
            };

            competitions.ForEach(s => context.Competition.Add(s));


            context.SaveChanges();

        }
    }
}
