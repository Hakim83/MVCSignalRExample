using MVCSignalRExample.DAL;
using MVCSignalRExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCSignalRExample.Controllers
{
    public class HomeController : Controller
    {
        Repository repo = new Repository();
        public ActionResult Index()
        {
            var foo = repo.GetData();
            return View(foo);
        }

        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Foo foo)
        {
            repo.UpdateData(foo);
            return View();
        }

    }
}