using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{

   public class Slide
   {
      public int Id { get; set; }
      public int Order { get; set; }
   }

   public class Presentation
   {
      public int Id { get; set; }
      [Required]
      [StringLength(255)]
      public string Name { get; set; }
      public List<Slide> Slides { get; set; }

      //foreign keys
      public int CollectionId { get; set; }
      public Collection Collection { get; set; }

   }

   public class Collection
   {
      public int Id { get; set; }
      [Required]
      [StringLength(255)]
      public string Name { get; set; }
      
      //foreign keys
      public List<Presentation> Catalogs { get; set; }

   }
}