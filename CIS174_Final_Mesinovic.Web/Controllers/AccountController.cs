using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using CIS174_Final_Mesinovic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AllowAnonymousAttribute = System.Web.Mvc.AllowAnonymousAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace CIS174_Final_Mesinovic.Web.Controllers
{
    public class AccountController : Controller
    {
        private AccountOrchestrator accountOrchestrator = new AccountOrchestrator();
        /*
        public ActionResult Register()
        {
            return View();
        }*/
        public async Task<ActionResult> Register(RegisterAccountModel player)
        {
            if (string.IsNullOrWhiteSpace(player.PlayerName))
            {
                return View();
            }
                var upcount = await accountOrchestrator.RegisterAccount(new AccountViewModel
                {
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    Gender = player.Gender,
                    Age = player.Age,
                    Email = player.Email,
                    Phone = player.Phone,
                    PlayerName = player.PlayerName,
                    UserPassword = player.UserPassword
                });
                return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public async Task<JsonResult> UpdateAccount(UpdateAccountModel player)
        {
            if (player.Email == "")
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            var result = await accountOrchestrator.UpdateAccount(new AccountViewModel
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
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> Search(string searchstring)
        {
            var viewmodel = await accountOrchestrator.SearchAccount(searchstring);
            return Json(viewmodel, JsonRequestBehavior.AllowGet);
        }
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginAccount(LogInViewModel entity)
        {

            return View();
        }*/
        /*
            public ActionResult Validate(LogInAccountModel admin)
        {
            var _admin = accountOrchestrator.(s => s.Email == admin.Email);
            if (_admin.Any())
            {
                if (_admin.Where(s => s.Password == admin.UserPassword).Any())
                {

                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = true, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }*/
        [HttpPost]
        // token validation causes error 
        //     [ValidateAntiForgeryToken]   
        public ActionResult LogInAccount(LogInViewModel objUser)
        {
            if (ModelState.IsValid)
            {
                using (SchoolContext db = new SchoolContext())
                {
                    var obj = db.Player.Where(a => a.Email.Equals(objUser.Email) && a.UserPassword.Equals(objUser.UserPassword)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["Email"] = obj.Email.ToString();
                        Session["FirstName"] = obj.FirstName.ToString();
                        Session.Timeout = 20;
                        return RedirectToAction("PlayerDashBoard");
                    }
                }
            }


            return View(objUser);
        }

        public ActionResult PlayerDashBoard()
        {
            if (Session["Email"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LogInAccount");
            }
        }
    }
}