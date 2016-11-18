using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Praise.Models;
using Praise.DAL;

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
        public ActionResult MakePraise(PraiseContext())
        {
            //Step1:Take out all the name from 'AccountInfo'
            private PraiseContext db1 = new PraiseContext();
            return View(db1.Name.ToList());
        }
            
     }

     
}