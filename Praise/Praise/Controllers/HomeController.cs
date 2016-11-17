using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Praise.Models;

namespace Praise.Controllers
{
    public class HomeController : Controller
    {
        private PraiseContext db = new PraiseContext();
        // update
        
        public ActionResult Update(IList<Detail> details)
        {
            details = details ?? new List<Detail>();
            return View(details);
        }

        public ActionResult MakePraise()
        {
            return View(new Detail());
        }
        [HttpPost]
        public ActionResult MakePraise(IEnumerable<AccountInfo> accounts)
        {
            System.Data.DataTable dt = 
            var accounts = from a in AccountInfo
                            select a.Name;

            return View();
        }
            
     }

     
}