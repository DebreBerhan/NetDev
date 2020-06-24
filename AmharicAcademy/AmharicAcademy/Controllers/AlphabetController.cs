using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmharicAcademy.Models;

namespace AmharicAcademy.Controllers
{
    public class AlphabetController : Controller
    {
        private AlphabetContext db = new AlphabetContext();
        // GET: Alphabet
        public ActionResult Index()
        {
            return View(db.AmAlphabets.ToList());
        }
    }
}