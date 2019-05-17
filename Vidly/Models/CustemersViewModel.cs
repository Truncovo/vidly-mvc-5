using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Vidly.Models
{
   public class CustemersViewModel
   {
      public IEnumerable<Customer> Customers { get; set; }
   }

   public class MoviesViewModel
   {
      public IEnumerable<Movie> Movies{ get; set; }
   }
}