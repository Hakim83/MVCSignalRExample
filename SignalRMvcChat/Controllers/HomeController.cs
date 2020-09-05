using Microsoft.AspNet.SignalR;
using SignalRChat;
using SignalRMvcChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRMvcChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Chat()
        {
            return View();
        }
        public ActionResult ChatServer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChatServer(ChatInfo info)
        {
            ChatHub.SendAll(info.Name, info.Message);
            return View();
        }
    }
}