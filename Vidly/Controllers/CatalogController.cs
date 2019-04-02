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
      public ViewResult Random()
      {
         var catalog = new Catalog()
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


      public ActionResult Slide(string presentationName, int? slide)
      {
         if (!slide.HasValue)
            slide = 1;
         return Content("ICeland in catalog: " + presentationName + "on slide " + slide);
      }
   }
}