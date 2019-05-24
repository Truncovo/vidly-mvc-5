using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewsModels
{
   public class EditTeamViewModel
   {
      public Team Team { get; set; }
      public IEnumerable<Category> Categories { get; set; }
   }

   public class TeamLoginViewModel
   {
      public int TeamId { get; set; } 
      public string Password { get; set; }
      public string Email { get; set; }
      public string TeamName { get; set; }
   }

   public class TeamsViewModel
   {
      public IEnumerable<Team> Teams { get; set; }
   }

   
}