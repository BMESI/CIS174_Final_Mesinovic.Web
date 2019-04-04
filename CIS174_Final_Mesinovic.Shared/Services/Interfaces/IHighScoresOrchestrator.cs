using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.Services.Interfaces
{
    public interface IHighScoresOrchestrator
    {
        List<HighScoresViewModel> GetHighScores();
        // i think i will need this to check if new score is the highest score
        bool IsHighestScore(HighScore score);

    }
}
