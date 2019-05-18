using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.HtmlHelper
{
   public static class HtmlT
   {
      public static string AddTd(string content)
      {
         if (content == null)
            return "-";
         return content;
      }
   }
}