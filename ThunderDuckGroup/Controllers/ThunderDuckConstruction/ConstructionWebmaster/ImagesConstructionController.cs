using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThunderDuckGroup.Models;
namespace ThunderDuckGroup.Controllers.ThunderDuckConstruction.ConstructionWebmaster
{
    public class ImagesConstructionController : Controller
    {
        ThunderDuckEntities db = new ThunderDuckEntities();
        // GET: ImagesConstruction
        public ActionResult List()
        {
            if (Session["Authentication"] != null)
            {
                var lst = db.Td_Construction_Images.ToList();
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
                var lst = db.Td_Construction_Images.ToList();
                return View(lst);
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        [HttpPost]
        public ActionResult Create(string title, HttpPostedFileBase images)
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

                var ls = new Td_Construction_Images();
                ls.Title = title;
                if (Images != "")
                {
                    ls.Images = Images;
                }
                db.Td_Construction_Images.Add(ls);
                db.SaveChanges();

                return RedirectToAction("List", "ImagesConstruction");
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        public ActionResult Edit(int id)
        {
            var img = db.Td_Construction_Images.ToList();
            ConMaster data = new ConMaster();
            List<ConMaster> ls = new List<ConMaster>();
            data.ima = img;
            ls.Add(data);
            return View(ls);
        }
        [HttpPost]
        public ActionResult Edit(int id, string title, HttpPostedFileBase images)
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
                var ls = db.Td_Construction_Images.Find(id);
                ls.Title = title;
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
                var img = db.Td_Construction_Images.Find(id);
                db.Entry(img).State = System.Data.Entity.EntityState.Deleted;
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