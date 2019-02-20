using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.Orchestrators.Interfaces;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// player orch ; added: 2/14/19
namespace CIS174_Final_Mesinovic.Shared.Orchestrators
{
    public class AccountOrchestrator : IAccountOrchestrator
    {
        private readonly SchoolContext _schoolContext;
        public AccountOrchestrator()
        {
            _schoolContext = new SchoolContext();
        }
        public async Task<int> RegisterAccount(AccountViewModel player)
        {
            _schoolContext.Player.Add(new Domain.Entities.Player
            {

                PersonId = player.PersonId,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Age = player.Age,
                Gender = player.Gender,
                Email = player.Email,
                Phone = player.Phone,
                PlayerName = player.PlayerName,
                UserPassword = player.UserPassword,

            });
            return await _schoolContext.SaveChangesAsync();
        }
        public List<AccountViewModel> GetPlayer()
        {
            var player = _schoolContext.Player.Select(m => new AccountViewModel
            {
                // left side = view model ; right side = database
                PersonId = m.PersonId,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Age = m.Age,
                Gender = m.Gender,
                Email = m.Email,
                Phone = m.Phone,
                PlayerName = m.PlayerName,
                UserPassword = m.UserPassword
            }).ToList();
            return player;
        }

        public async Task<bool> UpdateAccount(AccountViewModel player)
        {
            var updateEnt = await _schoolContext.Player.FindAsync(player.PersonId);
            if (updateEnt == null)
            {
                return false;
            }
            updateEnt.FirstName = player.FirstName;
            updateEnt.LastName = player.LastName;
            updateEnt.Gender = player.Gender;
            updateEnt.Email = player.Email;
            updateEnt.Age = player.Age;
            updateEnt.Phone = player.Phone;
            updateEnt.UserPassword = player.UserPassword;
            updateEnt.PlayerName = player.PlayerName;
            await _schoolContext.SaveChangesAsync();
            return true;
        }

        public async Task<AccountViewModel> SearchAccount(string searchstring)
        {
            var player = await _schoolContext.Player.Where(m => m.Email.StartsWith(searchstring)).FirstOrDefaultAsync();
            if (player == null)
            {
                return new AccountViewModel();
            }
            var viewmodel = new AccountViewModel
            {
                PersonId = player.PersonId,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Gender = player.Gender,
                Age = player.Age,
                Phone = player.Phone,
                PlayerName = player.PlayerName,
                Email = player.Email,
                UserPassword = player.UserPassword
            };
            return viewmodel;
        }

        public  async Task<bool> LogIn(AccountViewModel player)
        {
            //   var _admin =  await _schoolContext.Player.Where(x => x.Email == player.Email).ToList();
            //  var pss = await _schoolContext.Player.SingleOrDefault(x => x.UserPassword == player.UserPassword);
            var obj = _schoolContext.Player.Where(a => a.Email.Equals(player.Email) && a.UserPassword.Equals(player.UserPassword)).FirstOrDefault();
            //var email  = _schoolContext.Player.Where(x => x.Email == player.Email).ToList();
            //var pss = _schoolContext.Player.SingleOrDefault(x => x.UserPassword == player.UserPassword);
            if (obj.ToString() == player.ToString() )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LogInAccount(AccountViewModel player)
        {
            var obj = _schoolContext.Player.Where(a => a.Email.Equals(player.Email) && a.UserPassword.Equals(player.UserPassword)).FirstOrDefault();
            //var email  = _schoolContext.Player.Where(x => x.Email == player.Email).ToList();
            //var pss = _schoolContext.Player.SingleOrDefault(x => x.UserPassword == player.UserPassword);
            if (obj.ToString() == player.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

