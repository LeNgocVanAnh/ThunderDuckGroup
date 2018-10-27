using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThunderDuckGroup.Models;
namespace ThunderDuckGroup.Controllers.ThunderDuckBrandMaker.BrandMakerWebmaster
{
    public class NewsBrandMakerController : Controller
    {
        ThunderDuckEntities db = new ThunderDuckEntities();
        // GET: NewsBrandMaker
        public ActionResult List()
        {
            if (Session["Authentication"] != null)
            {
                var lst = db.Td_News.ToList();
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
                var lst = db.Td_News.ToList();
                return View(lst);
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        [HttpPost]
        public ActionResult Create (string title, string des, HttpPostedFileBase images)
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
                        var path = Path.Combine(Server.MapPath("~/Images/ThunderDuckGroup/imageNew"), fname);
                        images.SaveAs(path);
                        Images += fname;
                    }
                }
               
                var ls = new Td_News();
                ls.Title = title;
                ls.Description = des;
                if (Images != "")
                {
                    ls.Images = Images;
                }
                db.Td_News.Add(ls);
                db.SaveChanges();

                return RedirectToAction("List", "NewsBrandMaker");
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        public ActionResult Edit(int id)
        {
            var nw1 = db.Td_News.ToList();
            HomeMaster data = new HomeMaster();
            List<HomeMaster> ls = new List<HomeMaster>();
            data.newss = nw1;
            ls.Add(data);
            return View(ls);
        }
        [HttpPost]
        public ActionResult Edit(int id, string title, string des, HttpPostedFileBase images)
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
                        var path = Path.Combine(Server.MapPath("~/Images/ThunderDuckGroup/imageNew"), fname);
                        images.SaveAs(path);
                        Images += fname;
                    }
                }
                var ls = db.Td_News.Find(id);
                ls.Title = title;
                ls.Description = des;
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

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (Session["Authentication"] != null)
            {
                var news = db.Td_News.Find(id);
                db.Entry(news).State = System.Data.Entity.EntityState.Deleted;
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