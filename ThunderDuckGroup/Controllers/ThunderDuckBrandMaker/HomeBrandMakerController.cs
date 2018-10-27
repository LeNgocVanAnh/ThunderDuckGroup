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
            var events = db.Td_Events.ToList();
            var image = db.Td_Images.Where(st => st.id == 1);
            var newss = db.Td_News.ToList();
            var contact = db.Td_Contact.Where(st => st.id == 1);
            var slide = db.Td_Slider.Where(st => st.id == 1);
            var mems = db.Td_Members.ToList();
            home.sto = story;
            home.tou = tour;
            home.eve = events;
            home.img = image;
            home.newss = newss;
            home.con = contact;
            home.sli = slide;
            home.mem = mems;
            lst.Add(home);
            return View(lst);
        }
    }
}