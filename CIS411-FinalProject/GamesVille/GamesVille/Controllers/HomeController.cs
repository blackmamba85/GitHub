﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using GamesVille.Models;

namespace GamesVille.Controllers
{
    public class HomeController : Controller
    {
        private GameDBContext db = new GameDBContext();

        public ActionResult Index()
        {
            return View(db.Games.ToList());
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
    }
}