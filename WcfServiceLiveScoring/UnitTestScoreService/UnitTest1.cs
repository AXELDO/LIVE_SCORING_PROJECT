using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestScoreService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAllScores()
        {
            WebRequest request = WebRequest.Create("http://localhost:54513/ServiceLiveScoring/ScoreService/GetAllScores/");
            WebResponse ws = request.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding(1252);
            StreamReader responseStream = new StreamReader(ws.GetResponseStream());
            string response = responseStream.ReadToEnd();
            responseStream.Close();
            Assert.IsTrue(response.Length > 0);
        }
    }
}
