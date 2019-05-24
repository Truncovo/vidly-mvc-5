using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dto
{
   public class TeamDto
   {
      public int Id { get; set; }
      [Required]
      public string Name { get; set; }
      public string Coach { get; set; }
      [EmailAddress]
      public string Email { get; set; }
      [MaxLength(15)]
      [MinLength(3)]
      public string Password { get; set; }
      [CanBeFiledInWhenEmailIsFilled]
      public string Note { get; set; }
      public int CategoryId { get; set; }
   }
}