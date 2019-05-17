using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;


namespace Vidly.Controllers
{
   public class MoviesController : Controller
   {
      // GET: Movies
      private ApplicationDbContext _dbContext;
      public MoviesController()
      {
         _dbContext = new ApplicationDbContext();
      }

      public ActionResult Index()
      {
         var movies = _dbContext.Movies;
         return View(new MoviesViewModel{Movies = movies});
      }

      

      public ActionResult Edit(int Id)
      {
         return Content("ID=" + Id);
      }

      public ActionResult Detail(int Id)
      {
         var movie = _dbContext.Movies.Include(m => m.Genres).SingleOrDefault(m => m.Id == Id);
         return View(movie);
      }


      [Route("movies/ByReleaseDate2/{year:Regex(\\d{4})}/{month:Regex(\\d{2}):Range(1,12)}")]
      public ActionResult ByReleaseDate2(int year, int month)
      {
         return Content($"Year = {year}     month = {month}");

      }

      public ActionResult ByReleaseDate(int year, int month)
      {
         return Content($"Year = {year}     month = {month}");
      }
   }
}