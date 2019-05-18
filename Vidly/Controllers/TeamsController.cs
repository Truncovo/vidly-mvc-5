using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewsModels;

namespace Vidly.Controllers
{
    public class TeamsController : Controller
    {
       private ApplicationDbContext _context;
       public TeamsController()
       {
          _context = new ApplicationDbContext();
       }
        // GET: Teams
        public ActionResult Index()
        {
           var model = new TeamsViewModel();
           model.Teams = _context.Teams;
            return View(model);
        }

       public ActionResult Edit(int Id)
       {
          var team = _context.Teams.FirstOrDefault(t => t.Id == Id);

          return View(team);
       }
      [HttpPost]
      [ValidateAntiForgeryToken]
       public ActionResult Save(Team team)
      {
         if (!ModelState.IsValid)
            return View("Edit",team);

         var dbTeam =_context.Teams.Find(team.Id);
         if(dbTeam == null)
         { 
            dbTeam = new Team();
            _context.Teams.Add(dbTeam);
         }
         dbTeam.Password= team.Password;
         dbTeam.Email = team.Email;
         dbTeam.Coach = team.Coach;
         dbTeam.Note = team.Note;

         _context.SaveChanges();

         return RedirectToAction("Index", "Teams");
      }
    }
}