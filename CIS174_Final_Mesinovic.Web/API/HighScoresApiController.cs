using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.Services.Interfaces;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CIS174_Final_Mesinovic.Web.API
{
    [Route("api/v1/HighScores")]
    public class HighScoresApiController : ApiController , IHighScoresOrchestrator
    {
        private readonly Shared.Orchestrators.HighScoresOrchestrator _highscoresorchestrator;

        // GET api/<controller>
         public HighScoresApiController()
        {
            _highscoresorchestrator = new HighScoresOrchestrator();
        }
        [HttpGet]
        public List<HighScoresViewModel> GetHighScores()
        {
            // members == 
            /* old code         */
            var scores = _highscoresorchestrator.GetHighScores();
            return scores.ToList();
           
        }

        public bool IsHighestScore(HighScore score)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        /// <summary>
        /// Post method for leaderboard
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public void PostNewScore(HighScore score)
        {
        
                if ( (ModelState.IsValid))
            {

                _highscoresorchestrator.PostNewScore(score);
     
                }
            

        }
        /*
    /// <summary>
    /// Post method for leaderboard
    /// </summary>
    /// <param name="score"></param>
    /// <returns></returns>
    /// /*
    public void Broken(HighScore score)
    {

        if ((ModelState.IsValid))
        {
            using (var postscore = new SchoolContext())
            {

                postscore.Leaderboard.Add(new HighScore()
                {

                    HighScoreId = score.HighScoreId,
                    PersonId = score.PersonId,
                    DateAttained = score.DateAttained,
                    Score = score.Score

                });

                postscore.SaveChanges();
            }
        }

    }
    */


    }
}
