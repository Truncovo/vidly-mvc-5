using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Provider;
using Vidly.Models;
using Vidly.ViewsModels;

namespace Vidly.Controllers
{

   public partial class TeamsController : Controller

   {
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Save(EditTeamViewModel model)
      {
         if (!ModelState.IsValid)
            return View("Edit", model);

         var dbTeam = GetTeam(model.Team.Id);
         if (dbTeam == null)
         {
            dbTeam = new Team();
            _context.Teams.Add(dbTeam);
         }

         dbTeam.Name = model.Team.Name;
         dbTeam.Password = model.Team.Password;
         dbTeam.Email = model.Team.Email;
         dbTeam.Coach = model.Team.Coach;
         dbTeam.Note = model.Team.Note;
         dbTeam.CategoryId = model.Team.CategoryId;

         try
         {
            _context.SaveChanges();

         }
         catch (DbEntityValidationException e)
         {
            Console.WriteLine(e);
            throw;
         }

         return RedirectToAction("Index", "Teams");
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult LogOwner(TeamLoginViewModel model)
      {
         var team = GetTeam(model.TeamId);
         if(team == null)
            return View("NoTeam");

         if (model.Password == team.Password)
            return View("Edit",GetEditTieamViewModel(team));
         return View("TeamLogIn",model);
      }

      private Team GetTeam(int id)
      {
         return _context.Teams.FirstOrDefault(t => t.Id == id);
      }

      private EditTeamViewModel GetEditTieamViewModel(Team team)
      {
         return new EditTeamViewModel
         {
            Team = team,
            Categories = _context.Categories
         };
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult CreateOwner(TeamLoginViewModel model)
      {
         var team = GetTeam(model.TeamId);
         team.Email = model.Email;
         team.Password = model.Password;
         _context.SaveChanges();
         return Edit(model.TeamId);
      }


   }

    public partial class TeamsController : Controller
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
           model.Teams = _context.Teams.ToList();
            return View(model);
        }

       public ActionResult Vertify(int Id)
       {
          

          Team team = GetTeam(Id);
          if (team == null)
             return View("NoTeam");


         var model = new TeamLoginViewModel();
          model.TeamId = Id;
          model.TeamName = team.Name;

         if (team.HasOwner())
            return View("TeamLogIn",model);
          return View("CreateOwner", model);
       }


       [HttpPost]
       [ValidateAntiForgeryToken]
      public ActionResult TeamAfterLogIn(TeamLoginViewModel model)
       {
          Team team = GetTeam(model.TeamId);
          if (team == null)
             return View("NoTeam");

         if (model.Password != team.Password)
          {
             model.Password = "";
             return View("TeamLogIn", model);
         }
         return Edit(model.TeamId);
       }

      private ActionResult Edit(int Id = 0)
      {
         Team team = GetTeam(Id);
         if (team == null)
            return View("NoTeam");
      
         var model = new EditTeamViewModel
         {
            Team = team,
            Categories = _context.Categories
         };
          return View("Edit",model);
      }


    }
}