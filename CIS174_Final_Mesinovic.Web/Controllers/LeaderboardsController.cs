using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.Services.Interfaces;
using CIS174_Final_Mesinovic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CIS174_Final_Mesinovic.Web.Controllers
{
    public class LeaderboardsController : Controller
    {
        private readonly IHighScoresOrchestrator _scoresOrchestrator;
        public LeaderboardsController(IHighScoresOrchestrator scoresOrchestrator)
        {
            _scoresOrchestrator = scoresOrchestrator;
        }
        // GET: Leaderboards
        public ActionResult ViewScores()
        {
            var scoresViewModel = new LeaderboardsViewModel
            {
                Scores = _scoresOrchestrator.GetHighScores()
            };
            return View(scoresViewModel);
        }
    }
}