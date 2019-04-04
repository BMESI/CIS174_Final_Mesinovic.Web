using AutoMoq;
using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Test
{
    [TestClass]
    public class IntegrationTests
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();
        [TestInitialize]
        [TestMethod]
        public void Initialize()
        {
            // Sets up high scores
              var HighScoresViewModel_ = _mocker.Create<HighScore>();
            HighScoresViewModel_.HighScoreId = Guid.Parse("22222222-4422-1333-4444-555555555555");
            HighScoresViewModel_.PersonId = Guid.Parse("22111111-1111-3333-4444-555555555555");
            HighScoresViewModel_.Score = 13;
            HighScoresViewModel_.DateAttained = DateTime.Now;
            var HighScoresViewModel_2 = _mocker.Create<HighScore>();
            HighScoresViewModel_2.HighScoreId = Guid.Parse("11111111-4422-1333-4444-555555555555");
            HighScoresViewModel_2.PersonId = Guid.Parse("22111111-1111-3333-4444-555555555555");
            HighScoresViewModel_2.Score = 14;
            HighScoresViewModel_2.DateAttained = DateTime.Now;

            // set up leaderboard/collection
            var leaderboard = _mocker.Create<HighScoresOrchestrator>();

            //Calls the method that updates a player's high score 
            leaderboard.PostNewScore_UT(HighScoresViewModel_);
            leaderboard.PostNewScore_UT(HighScoresViewModel_2);
            //Calls that method that returns the leader board
            leaderboard.GetHighScores();
            int shouldreturnTwoscores = 2;
            // it fails; w/o the given exception, it will throw a sql exception for some reason, even though it saves to a list
            Assert.AreEqual(leaderboard.GetHighScores().Count, shouldreturnTwoscores);
        }

    }
}
