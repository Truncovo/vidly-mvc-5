﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewsModels
{
   public class TeamsViewModel
   {
      public IEnumerable<Team> Teams { get; set; }
   }
}