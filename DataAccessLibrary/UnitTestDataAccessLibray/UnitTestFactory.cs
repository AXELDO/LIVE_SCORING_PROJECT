using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLibrary;

namespace UnitTestDataAccessLibray
{
    [TestClass]
    public class TestFactory
    {

        [TestMethod]
        public void TestGetAllScores()
        {
            Assert.IsTrue(Factory.GetAllScores().Count > 0);
        }


        [TestMethod]
        public void TestGetCompetitions()
        {
            Assert.IsTrue(Factory.GetCompetitions().Count > 0);
        }

        [TestMethod]
        public void TestGetCompetitionsByType()
        {
            Assert.IsTrue(Factory.GetCompetitionsByType(DataAccessLibrary.Models.CompetitionType.ChampionsLeague).Count > 0
                && Factory.GetCompetitionsByType(DataAccessLibrary.Models.CompetitionType.UEFACup).Count > 0
                && Factory.GetCompetitionsByType(DataAccessLibrary.Models.CompetitionType.WorldCup).Count > 0);
        }

        [TestMethod]
        public void TestGetLiveScores()
        {
            Assert.IsTrue(Factory.GetLiveScores().Count > 0);
        }

        [TestMethod]
        public void TestGetScoresOfDay()
        {
            Assert.IsTrue(Factory.GetScoresOfDay().Count > 0);
        }

        [TestMethod]
        public void TestGetScoresOfWeek()
        {
            Assert.IsTrue(Factory.GetScoresOfWeek().Count > 0);
        }

        [TestMethod]
        public void TestGetScoresOfMonth()
        {
            Assert.IsTrue(Factory.GetScoresOfMonth().Count > 0);
        }

        [TestMethod]
        public void TestGetNextScores()
        {
            Assert.IsTrue(Factory.GetNextScores().Count > 0);
        }

        [TestMethod]
        public void TestGetAllScoresByCompetition()
        {
            Assert.IsTrue(Factory.GetAllScoresByCompetition(1).Count > 0);
        }
    }
}
