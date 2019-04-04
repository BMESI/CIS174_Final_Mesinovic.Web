using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.ViewModels
{
    public class HighScoresViewModel
    {
        public Guid HighScoreId { get; set; }
        public Guid PersonId { get; set; }
        public int Score { get; set; }
        public DateTime DateAttained { get; set; }
        public List<HighScoresViewModel> HSList { get; set; }

    }
}
