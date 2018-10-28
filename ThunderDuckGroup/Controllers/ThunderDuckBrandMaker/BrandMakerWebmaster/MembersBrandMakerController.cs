using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThunderDuckGroup.Models;
using System.IO;

namespace ThunderDuckGroup.Controllers.ThunderDuckBrandMaker.BrandMakerWebmaster
{
    public class MembersBrandMakerController : Controller
    {
        ThunderDuckEntities db = new ThunderDuckEntities();
        // GET: MembersBrandMaker
        public ActionResult List()
        {
            if(Session["Authentication"] != null)
            {
                var lst = db.Td_BrandMaker_Members.ToList();
                return View(lst);
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
           
        }

        public ActionResult Create()
        {
            if (Session["Authentication"] != null)
            {
                var lst = db.Td_BrandMaker_Members.ToList();
                return View(lst);
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        [HttpPost]
        public ActionResult Create(string title, string subtitle, HttpPostedFileBase images)
        {
            if(Session["Authentication"] != null)
            {
                string Images = "";
                if (images != null)
                {
                    if(images.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(images.FileName);
                        var fname = filename.Replace(" ", "_");
                        var path = Path.Combine(Server.MapPath("/Images/ThunderDuckGroup/imageHome"), fname);
                        images.SaveAs(path);
                        Images += fname;
                    }
                }

                var home = new Td_BrandMaker_Members();
                home.Title = title;
                home.Subtitle = subtitle;
                if(Images != null)
                {
                    home.Images = Images;
                }
                db.Td_BrandMaker_Members.Add(home);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["Authentication"] != null)
            {
                var mems = db.Td_BrandMaker_Members.Find(id);
                db.Entry(mems).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("List", "MembersBrandMaker");
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }
        
        public ActionResult Edit(int id)
        {
            var mb = db.Td_BrandMaker_Members.ToList();
            HomeMaster data = new HomeMaster();
            List<HomeMaster> ls = new List<HomeMaster>();
            data.mem = mb;
            ls.Add(data);
            return View(ls);
        }

        [HttpPost]
        public ActionResult Edit(int id, string title, string subtitle, HttpPostedFileBase images)
        {

            if (Session["Authentication"] != null)
            {

                string Images = "";
                if (images != null)
                {
                    if (images.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(images.FileName);
                        var fname = filename.Replace(" ", "_");
                        var path = Path.Combine(Server.MapPath("~/Images/ThunderDuckGroup/imageHome"), fname);
                        images.SaveAs(path);
                        Images += fname;
                    }
                }
                var ls = db.Td_BrandMaker_Members.Find(id);
                ls.Title = title;
                ls.Subtitle = subtitle;
                if (Images != "")
                {
                    ls.Images = Images;
                }
                db.Entry(ls).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("List");
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }
    }
}