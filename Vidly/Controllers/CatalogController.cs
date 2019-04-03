using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
   public class CatalogController : Controller
   {
      private ApplicationDbContext _context;


      public ViewResult Random()
      {
         var catalog = new Presentation()
         {
            Name = "WestFjords",
            Id = 1
         };

         ViewData["WestFjords"] = catalog;

         return View();
      }

      public ActionResult Edit(int id)
      {
         return Content("id:" + id);
      }

      [Route("Iceland/{Name}/{Slide:regex(\\d{2}):range(1,55)}")]
      public ActionResult ShowSlide(string name, int? slide)
      {
         if (name == null)
            name = "Name Was Null";
         return Content(name + " slide: " + slide);
      }

      [Route("Iceland/{id}")]
      public ActionResult Catalog(int id)
      {
         var ce = _context.Catalogs.SingleOrDefault(c => c.Id == id);

         if (ce == null)
            return HttpNotFound();

         return View(ce);
      }
      

      public CatalogController()
      {
         _context = new ApplicationDbContext();
      }

      protected override void Dispose(bool disposing)
      {
         base.Dispose(disposing);
         _context.Dispose();
      }

      [Route("Iceland")]
      public ActionResult Iceland()
      {
         List<Presentation> catalog = _context.Catalogs.ToList();
         return View(catalog);
      }

      public ActionResult Slide(string presentationName, int? slide)
      {
         if (!slide.HasValue)
            slide = 1;
         return Content("ICeland in catalog: " + presentationName + "on slide " + slide);
      }
   }
}