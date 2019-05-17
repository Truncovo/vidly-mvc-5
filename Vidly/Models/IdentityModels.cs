using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       public DbSet<Movie> Movies { get; set; }
       public DbSet<Customer> Customers { get; set; }
       public DbSet<SubModel> SubModels { get; set; }
       public DbSet<Genre> Genres { get; set; }
       public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

   public class Movie
   {
      public int Id { get; set; }
      [Required]
      [StringLength(255)]
      public string Name { get; set; }
      public List<Genre> Genres { get; set; }
      [Required]
      public int TotalCopies { get; set; }
      [Required]
      public int AvalibleCopies{ get; set; }
      [Required]
      public DateTime BirthDate { get; set; }

   }

   public class Customer
   {
      public int Id { get; set; }
      [Required]
      [StringLength(255)]
      public string Name { get; set; }
      [Required]
      public bool NewsLetter { get; set; }
      [Required]
      public SubModel SubModel { get; set; }
      public DateTime? BirthDate { get; set; }
   }

   public class Genre
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public List<Movie> Movies{ get; set; }

   }

   public class SubModel
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Discount { get; set; }
   }
}