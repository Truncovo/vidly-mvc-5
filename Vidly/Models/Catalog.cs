using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
   public class Catalog
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public List<string> Slides { get; set; }

   }

   public class CatalogCollection
   {
      public List<Catalog> Catalogs { get; set; }

   }
}