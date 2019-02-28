using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.Orchestrators.Interfaces
{
    public interface IAccountOrchestrator
    {
         Task<int> RegisterAccount(AccountViewModel player);
        Task<bool> UpdateAccount(AccountViewModel player);
        Task<AccountViewModel> SearchAccount(string searchstring);
        Task<bool> Login(AccountViewModel player);

        //   Task<PlayerViewModel> SearchPlayer(PlayerViewModel player);

    }
}
