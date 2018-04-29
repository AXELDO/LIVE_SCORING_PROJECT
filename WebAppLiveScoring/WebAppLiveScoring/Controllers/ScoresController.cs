using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAppLiveScoring.ImportData;
using WebAppLiveScoring.Models;

namespace WebAppLiveScoring.Controllers
{
    public class ScoresController : Controller
    {
        private I_ServiceImportData _importService;

        public ScoresController()
        {
            _importService = new ImportScoreByWebService();
        }


        public IActionResult Index()
        {
            List<Score> list = _importService.GetAllScores();

            TempData["Scores"] = JsonConvert.SerializeObject(list);
                
            return View(_importService.GetAllScores().ToList());
        }

        public IActionResult Details(int id)
        {
            Score currentScore = null;
            if (TempData["Scores"] != null)
            {
                var list = JsonConvert.DeserializeObject<List<Score>>(TempData["Scores"].ToString());

                currentScore = list.Where(s => s.ScoreID == id).FirstOrDefault();
            }

            return View(currentScore);
        }
    }
}
