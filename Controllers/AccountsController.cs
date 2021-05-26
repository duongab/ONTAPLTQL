using ONTAPLTQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ONTAPLTQL.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        private OTLTQLDbContext db = new OTLTQLDbContext();

        // GET: Accounts
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account acc, string returnUrl)
        {
            var db = new OTLTQLDbContext();

            var model = db.Accounts.Where(t => t.Tendangnhap == acc.Tendangnhap && t.matkhau == acc.matkhau).ToList().Count();

            if (ModelState.IsValid)
            {
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.Tendangnhap, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(acc);

        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}