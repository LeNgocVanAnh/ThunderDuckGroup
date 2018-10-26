using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThunderDuckGroup.Models;
namespace ThunderDuckGroup.Controllers.ThunderDuckBrandMaker
{
    public class HomeBrandMakerController : Controller
    {
        ThunderDuckEntities db = new ThunderDuckEntities();
        // GET: HomeBrandMaker
        public ActionResult IndexBrandMaker()
        {
            List<HomeMaster> lst = new List<HomeMaster>();
            HomeMaster home = new HomeMaster();
            var story = db.Td_Story.Where(st => st.id == 1);
            var tour = db.Td_Tours.Where(st => st.id == 1);
            var events = db.Td_Events.Where(st => st.id == 1);
            var image = db.Td_Images.Where(st => st.id == 1);
            var newss = db.Td_News.Where(st => st.id == 1);
            var contact = db.Td_Contact.Where(st => st.id == 1);
            home.sto = story;
            home.tou = tour;
            home.eve = events;
            home.img = image;
            home.news = newss;
            home.con = contact;
            lst.Add(home);
            return View();
        }
    }
}