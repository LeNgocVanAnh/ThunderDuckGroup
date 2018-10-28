﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThunderDuckGroup.Models;
namespace ThunderDuckGroup.Controllers.ThunderDuckBrandMaker.BrandMakerWebmaster
{
    public class TourBrandMakerController : Controller
    {
        ThunderDuckEntities db = new ThunderDuckEntities();
        // GET: TourBrandMaker
        public ActionResult List()
        {
            if (Session["Authentication"] != null)
            {
                var lst = db.Td_BrandMaker_Tours.ToList();
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
                var lst = db.Td_BrandMaker_Tours.ToList();
                return View(lst);
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        [HttpPost]
        public ActionResult Create(string title, string des, string price,  HttpPostedFileBase images)
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

                var ls = new Td_BrandMaker_Tours();
                ls.Title = title;
                ls.Description = des;
                ls.Price = price;
                if (Images != "")
                {
                    ls.Images = Images;
                }
                db.Td_BrandMaker_Tours.Add(ls);
                db.SaveChanges();

                return RedirectToAction("List", "TourBrandMaker");
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        public ActionResult Edit(int id)
        {
            var tou = db.Td_BrandMaker_Tours.ToList();
            HomeMaster data = new HomeMaster();
            List<HomeMaster> ls = new List<HomeMaster>();
            data.tou = tou;
            ls.Add(data);
            return View(ls);
        }
        [HttpPost]
        public ActionResult Edit(int id, string title, string des, string price, HttpPostedFileBase images)
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
                var ls = db.Td_BrandMaker_Tours.Find(id);
                ls.Title = title;
                ls.Description = des;
                ls.Price = price;
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
                var tour = db.Td_BrandMaker_Tours.Find(id);
                db.Entry(tour).State = System.Data.Entity.EntityState.Deleted;
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