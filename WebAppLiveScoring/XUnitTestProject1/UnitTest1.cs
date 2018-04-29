using System;
using Xunit;
using WebAppLiveScoring.ImportData;

namespace XUnitTestProject1
{
    public class UnitTestImportService
    {
        [Fact]
        public void TestGetAllScores()
        {
            I_ServiceImportData serviceImport = new ImportScoreByWebService();

            Assert.True(serviceImport.GetAllScores().Count > 0);

        }
    }
}
