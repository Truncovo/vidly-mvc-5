using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
   public class CustomerController : Controller
   {
      private ApplicationDbContext _dbContext;
      public CustomerController()
      {
         _dbContext = new ApplicationDbContext();
      }

      protected override void Dispose(bool disposing)
      {
         _dbContext.Dispose();
      }
      // GET: Customer
      public ActionResult Index()
      {
         var model = new CustemersViewModel();
         model.Customers = _dbContext.Customers.Include(c => c.SubModel).ToList();
         
         return View(model);
      }

      public ActionResult Detail(int Id)
      {
         return View(_dbContext.Customers.Include(c=>c.SubModel).SingleOrDefault(c=>c.Id == Id));
      }

    
   }
}