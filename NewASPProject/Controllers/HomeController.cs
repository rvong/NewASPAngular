using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewASPProject.Models;

namespace NewASPProject.Controllers
{
    public class HomeController : Controller
    {
        private ADBEntities db = new ADBEntities();



        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(IList<CartItemViewModel> cartItems)
        {
            if (ModelState.IsValid)
            {
                foreach (var i in cartItems)
                {
                    var newItem = new Items2();
                    newItem.PName = i.PName;
                    newItem.Price = i.Price;
                    newItem.Qty = i.Qty;
                    db.Items2.Add(newItem);
                }
                db.SaveChanges();
                return Json(true);
            }
            else
                return Json(false);
        }
    }
}