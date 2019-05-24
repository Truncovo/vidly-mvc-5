using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using AutoMapper;
using Vidly.Dto;
using Vidly.Models;

namespace Vidly.App_Start
{
   public class MappingProfile : Profile
   {
      public MappingProfile()
      {
         Mapper.CreateMap<Team, TeamDto>();
         Mapper.CreateMap<TeamDto, Team>();

      }
   }
}