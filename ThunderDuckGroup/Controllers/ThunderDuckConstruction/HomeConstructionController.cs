﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThunderDuckGroup.Models;

namespace ThunderDuckGroup.Controllers.ThunderDuckConstruction
{
    public class HomeConstructionController : Controller
    {
        ThunderDuckEntities db = new ThunderDuckEntities();
        // GET: HomeConstruction
        public ActionResult IndexConstruction()
        {
            List<ConMaster> lst = new List<ConMaster>();
            ConMaster home = new ConMaster();
            var story = db.Td_Constrution_Story.Where(st => st.id == 1);
            var construc = db.Td_Construction_Construction.ToList();
            var image = db.Td_Construction_Images.ToList();
            var newss = db.Td_Construction_New.ToList();
            var contact = db.Td_Construction_Contact.Where(st => st.id == 1);
            var slide = db.Td_Construction_Slider.Where(st => st.id == 1);
            var mems = db.Td_Construction_Member.ToList();
            home.stor = story;
            home.conta = contact;
            home.constr = construc;
            home.ima = image;
            home.news = newss;
            home.conta = contact;
            home.slie = slide;
            home.meme = mems;
            lst.Add(home);
            return View(lst);
        }
    }
}