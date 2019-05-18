using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
   public class Team
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
      public SleepInfo SleepInfoDayOne { get; set; }
      public SleepInfo SleepInfoDayTwo { get; set; }

   }

   public class SleepInfo
   {
      public int Id { get; set; }
      public int PlayerCount { get; set; }
      public int MenCount { get; set; }
      public int WomanCount { get; set; }

   }
}