using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.Services.Interfaces;
using CIS174_Final_Mesinovic.Shared.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.Orchestrators
{

    public class HighScoresOrchestrator : IHighScoresOrchestrator
    {
        private readonly SchoolContext _schoolContext;
        public HighScoresOrchestrator()
        {
            _schoolContext = new SchoolContext();
        }
        public void PostNewScore(HighScore score)
        {
            {
                using (var postscore = new SchoolContext())
                {
                    try
                    {
                        /// using the IsHighestScore method/service, check right here to see if it should be updated.
                        if (IsHighestScore(score) == true)
                        {
                            postscore.Leaderboard.Add(new HighScore()
                            {
                                HighScoreId = score.HighScoreId,
                                PersonId = score.PersonId,
                                DateAttained = score.DateAttained,
                                Score = score.Score
                            });
                            //postscore.SaveChanges();
                        }
                    }
                    catch
                    {
                        // throwin not implemented, otherwise it throws some kind of sql exception
                        throw NotImplementedException();
                    }
                }
            }
        }
        // Using this method for Unit test(UT) ... 
        // it saves to a list instead of the db set
        //
        public void PostNewScore_UT(HighScore score)
        {
            {
                using (var postscore = new SchoolContext())
                {
                    try
                    {
                        /// using the IsHighestScore method/service, check right here to see if it should be updated.
                        if (IsHighestScore(score) == true)
                        {
                            postscore.LeaderboardTestList.Add(new HighScore()
                            {
                                HighScoreId = score.HighScoreId,
                                PersonId = score.PersonId,
                                DateAttained = score.DateAttained,
                                Score = score.Score
                            });
                            //postscore.SaveChanges();
                        }
                    }
                    catch
                    {
                        // otherwise it throws some kind of sql exception
                        throw NotImplementedException();
                    }
                }
            }
        }
        private Exception NotImplementedException()
        {
            throw new NotImplementedException();
        }
        // according to postman , GetHighScores  returns the scores in correct order 
        //
        public List<HighScoresViewModel> GetHighScores()
        {
            var scores = _schoolContext.Leaderboard.Select(m => new HighScoresViewModel

            // left side = view model ; right side = database
            { 
             PersonId = m.PersonId,
             HighScoreId = m.HighScoreId,
            Score = m.Score,
             DateAttained = m.DateAttained ?? DateTime.MinValue
            }).ToList();

            // according to postman , this should return the scores in correct order 
            List<HighScoresViewModel> HS_Sorted = scores.OrderByDescending(o => o.Score).ToList();

            return HS_Sorted;
            /// Making sample data for Unit Test
            ///  ** wont use this  ** 
            /*   var scores = 
               new HighScoresViewModel
               {

                   PersonId = Guid.NewGuid(),
                   HighScoreId = Guid.NewGuid(),
                   Score = 123,
                   DateAttained = _DTSrvc.Now()

               };
               new HighScoresViewModel
                 {

                   PersonId = Guid.NewGuid(),
                   HighScoreId = Guid.NewGuid(),
                   Score = 13,
                   DateAttained =  _DTSrvc.Now()

                 }
                       */
            // return scores;


        }
        // THis method is not used as part of the main code -- only ut/practice
        // i tried to instatiate Viewmodels here and then assign properties...
        public List<HighScoresViewModel> GetHighScores_UT()
        {
            /// Making sample data for Unit Test
            var scores = _schoolContext.Leaderboard.Select(m => new HighScoresViewModel

            // left side = view model ; right side = database
            {
                PersonId = m.PersonId,
                HighScoreId = m.HighScoreId,
                Score = m.Score,
                DateAttained = m.DateAttained ?? DateTime.MinValue
            }).ToList();

            // according to postman , this should return the scores in correct order 
            List<HighScoresViewModel> HS_Sorted = scores.OrderByDescending(o => o.Score).ToList();

            return HS_Sorted;

            // making sort part of the gethighscores method
            //List<HighScoresViewModel> HS_Sorted = scores.OrderBy(o => o.Score).ToList();



        }
        //this method would check if the incoming score is higher than the previous
        // using the person id to relate to previous score 
        //
        public bool IsHighestScore(HighScore score)
        {
            bool status = true;
            /* just extra code that didnt work ...
            var scores = _schoolContext.Leaderboard.Where(m => m.PersonId == score.PersonId);
            HighScoresViewModel comparison = new HighScoresViewModel();
            comparison.PersonId = score.PersonId;
            comparison.Score = score.Score;
            comparison.DateAttained = DateTime.Now;
            */
            var HSdata = _schoolContext.Leaderboard.Where(x => x.PersonId == score.PersonId).FirstOrDefault();
            try
            {
                if (HSdata.PersonId.Equals(score.PersonId))
                {
                    if (HSdata.Score < score.Score)
                    {
                        HSdata.HighScoreId = score.HighScoreId;
                        HSdata.PersonId = score.PersonId;
                        HSdata.DateAttained = score.DateAttained;
                        HSdata.Score = score.Score;
                        _schoolContext.SaveChanges();
                        status = true;
                    }
                }
                else
                {
                    status = false;
                }
            }
            catch
            {
                return status;
            }
            return status;

        }
        // part of practice/ UT
        public bool IsHighestScore_UT(HighScore score)
        {
            bool status = true;
            /* just extra code that didnt work ...
            var scores = _schoolContext.Leaderboard.Where(m => m.PersonId == score.PersonId);
            HighScoresViewModel comparison = new HighScoresViewModel();
            comparison.PersonId = score.PersonId;
            comparison.Score = score.Score;
            comparison.DateAttained = DateTime.Now;
            */
            var HSdata = _schoolContext.Leaderboard.Where(x => x.PersonId == score.PersonId).FirstOrDefault();
           // var HS_Data_List = 
            if (HSdata.PersonId.Equals(score.PersonId))
            {
                if (HSdata.Score < score.Score)
                {
                    HSdata.HighScoreId = score.HighScoreId;
                    HSdata.PersonId = score.PersonId;
                    HSdata.DateAttained = score.DateAttained;
                    HSdata.Score = score.Score;
                    _schoolContext.SaveChanges();
                    status = true;
                }
            }
            else
            {
                status = false;
            }

            return status;

        }

        public bool IsHighestScore(HighScoresViewModel score)
        {
            throw new NotImplementedException();
        }
    }
}
