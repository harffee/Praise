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
        public ActionResult Update()
        {
            
        var query = from b in db.Details
                    orderby b.UpdateDate
                    select b;
        return View();
    }
        
            
     }

     
}