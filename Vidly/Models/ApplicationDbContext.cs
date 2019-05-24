using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Vidly.Controllers;

namespace Vidly.Models
{
   public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
   {
      public ApplicationDbContext()
         : base("DefaultConnection", throwIfV1Schema: false)
      {
      }
      public DbSet<Team> Teams { get; set; }
      public DbSet<SleepInfo> SleepInfos { get; set; }
      public DbSet<Category> Categories { get; set; }
      public static ApplicationDbContext Create()
      {
         return new ApplicationDbContext();
      }
   }
}