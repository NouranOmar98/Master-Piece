using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterPiece.Controllers
{
    public class WishListController : Controller
    {
        // GET: WishList
        public ActionResult WishList()
        {
            return View();
        }
    }
}