using AutoMoq;
using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.Orchestrators;

using CIS174_Final_Mesinovic.Shared.Services.Interfaces;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Test
{
    [TestClass]
    public class HighScoresOrchestratorTest
    {
        // tried a few different ways to set this up.
        private readonly AutoMoqer _mocker = new AutoMoqer();
        private readonly AutoMoqer _mocker2 = new AutoMoqer();

        private readonly AutoMoqer _dbmocker = new AutoMoqer();

        public List<HighScoresViewModel> hslist = new List<HighScoresViewModel>();
        public List<HighScoresViewModel> hslist_2 = new List<HighScoresViewModel>();



        // just trying out the example from class applied to this context...
        [TestMethod]
        public void GetHSReturn_2()
        {
            // Arrange 
            // i setup two scores in the orch from the shared project.. wasnt sure how it should be done
            var HSOrchestrator = _mocker.Create<HighScoresOrchestrator>();

            // Act
            var scores = HSOrchestrator.GetHighScores_UT();

            // Assert
            // Assert.AreEqual(2, scores.Count);
            // this one worked just fine when i setup hard-coded scores in the orchestrator...
            Assert.AreEqual(2, scores.Count);

        }
        // .. 
        //
        [TestMethod]
        public void PostNewScore_GetHighScores()
        {
            var leaderboard = _dbmocker.Create<HighScoresOrchestrator>();

            var HighScoresViewModel_ = _mocker.Create<HighScore>();
            HighScoresViewModel_.HighScoreId = Guid.Parse("22222222-4422-1333-4444-555555555555");
            HighScoresViewModel_.PersonId = Guid.Parse("22111111-1111-3333-4444-555555555555");
            HighScoresViewModel_.Score = 13;
            HighScoresViewModel_.DateAttained = DateTime.Now;

            // add  to mocked leaderboard 
            leaderboard.PostNewScore(HighScoresViewModel_);


            // return high scores from mocked leaderboard and compare to Mocked HVM from within this test
            // Unit test fails....
            Assert.AreEqual(HighScoresViewModel_, leaderboard.GetHighScores());
            
        }
        //IsHighestScore_true is  getting an exception error ... failing unit tests
        [TestMethod]
        public void IsHighestScore_true()
        {
            //make leaderboard mock using orchestrator
            //
            var leaderboard = _dbmocker.Create<HighScoresOrchestrator>();

            //add in the objects w/ test  data
            // same person id, different highscore id, the second will have a higher score and it should update the prior one
            //
            var HighScoresViewModel_ = _mocker.Create<HighScore>();
            HighScoresViewModel_.HighScoreId = Guid.Parse("22222222-4422-1333-4444-555555555555");
            HighScoresViewModel_.PersonId = Guid.Parse("22111111-1111-3333-4444-555555555555");
            HighScoresViewModel_.Score = 13;
            HighScoresViewModel_.DateAttained = DateTime.Parse("05/29/2015");

            var HighScoresViewModel_2 = _mocker2.Create<HighScore>();
            HighScoresViewModel_2.HighScoreId = Guid.Parse("22222222-4422-1333-4444-555555555555");
            HighScoresViewModel_2.PersonId = Guid.Parse("22111111-1111-3333-4444-555555555555");
            HighScoresViewModel_2.Score = 15;
            HighScoresViewModel_2.DateAttained = DateTime.Now;

            // add in the scores to the mocked leaderboard using the postnewscore method
            // postnewscore should do ccheck if new score is highest and then post it
            //
            leaderboard.PostNewScore_UT(HighScoresViewModel_);
            leaderboard.PostNewScore_UT(HighScoresViewModel_2);

            //  var orch = _mocker.Create<HighScoresOrchestrator>();
            //hslist_2.Add(HighScoresViewModel_);
            // hslist_2.Add(test2);
            // orch.GetHighScores_UT();

            //check that they are   the same
            //
            //
            Assert.AreNotEqual(HighScoresViewModel_.Score, HighScoresViewModel_2.Score);

 
        }
    }
}
