﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThunderDuckGroup.Controllers.Webmaster.ConstructionWebmaster
{
    public class WebmasterConstructionController : Controller
    {
        // GET: WebmasterConstruction
        public ActionResult Index()
        {
            if (Session["Authentication"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            if (Username.Equals("admin"))
            {
                if (Password.Equals("1234"))
                {
                    Session["Authentication"] = true;
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Login", "Webmaster");
                }
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }

        }

        [HttpPost]
        public ActionResult Logout()
        {
            if (Session["Authentication"] != null)
            {
                return RedirectToAction("null");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}