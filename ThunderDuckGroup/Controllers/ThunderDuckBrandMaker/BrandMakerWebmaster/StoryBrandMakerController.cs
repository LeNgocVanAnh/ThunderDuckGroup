﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThunderDuckGroup.Models;
namespace ThunderDuckGroup.Controllers.ThunderDuckBrandMaker.BrandMakerWebmaster
{
    public class StoryBrandMakerController : Controller
    {
        ThunderDuckEntities db = new ThunderDuckEntities();
        // GET: StoryBrandMaker
        public ActionResult Edit()
        {
            if(Session["Authentication"] != null)
            {
                var home = db.Td_Story.Where(st => st.id == 1);
                return View(home);
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }

        [HttpPost]
        public ActionResult Edit(string title, string des, HttpPostedFileBase images, HttpPostedFileBase sign)
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

                string Sign = "";
                if (sign != null)
                {
                    if (sign.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(sign.FileName);
                        var fname = filename.Replace(" ", "_");
                        var path = Path.Combine(Server.MapPath("~/Images/ThunderDuckGroup/imageHome"), fname);
                        sign.SaveAs(path);
                        Sign += fname;
                    }
                }

                var st = db.Td_Story.Find(1);
                st.Title = title;
                st.Description = des;

                if (Images != "")
                {
                    st.Images = Images;
                }
                if (Sign != "")
                {
                    st.Signature = Sign;
                }
                db.Entry(st).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit");
            }
            else
            {
                return RedirectToAction("Login", "Webmaster");
            }
        }
    }
}