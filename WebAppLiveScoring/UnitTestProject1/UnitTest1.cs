using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppLiveScoring.ImportData;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestImportService
    {
        [TestMethod]
        public void GetAllScores()
        {
            I_ServiceImportData importService = new ImportScoreByWebService();
            Assert.IsTrue(importService.GetAllScores().Count > 0);

        }
    }
}
