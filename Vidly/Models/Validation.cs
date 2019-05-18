using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Vidly.Models
{
   public class CanBeFiledInWhenEmailIsFilled : ValidationAttribute
   {
      protected override ValidationResult IsValid(object value, ValidationContext validationContext)
      {
         var team = (Team) validationContext.ObjectInstance;
         if(!team.Email.IsNullOrWhiteSpace())
            return ValidationResult.Success;
         if(team.Note.IsNullOrWhiteSpace())
            return ValidationResult.Success;
         return new ValidationResult("If you wana write note, write e-mail to");
      }
   }
}