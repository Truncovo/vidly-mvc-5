using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using AutoMapper;
using Vidly.Dto;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class TeamsController : ApiController
    {
       private ApplicationDbContext _context = new ApplicationDbContext();
       // api/Teams
       public IEnumerable<TeamDto> GetTeams()
       {
          return _context.Teams.Select(Mapper.Map<Team,TeamDto>); 
       }

       public TeamDto GetTeam(int Id)
       {
          var team = _context.Teams.SingleOrDefault(t => t.Id == Id);
          if(team == null)
             throw new HttpResponseException(HttpStatusCode.NotFound);
          return Mapper.Map<Team, TeamDto>(team);
       }
       [HttpPost]
       public TeamDto CreateTeam(TeamDto teamDto)
       {
         if(!ModelState.IsValid)
            throw new   HttpResponseException(HttpStatusCode.BadRequest);
          var team= Mapper.Map<TeamDto, Team>(teamDto);

          _context.Teams.Add(team);
          _context.SaveChanges();

          teamDto.Id = team.Id;
         return teamDto;
       }
      [HttpPut]
       public void UpdateTeam(int id, TeamDto teamDto)
       {
          if (!ModelState.IsValid)
             throw new HttpResponseException(HttpStatusCode.BadRequest);

          var teamInDb = _context.Teams.SingleOrDefault(t => t.Id == id);


          if(teamInDb == null)
             throw new HttpResponseException(HttpStatusCode.NotFound);

          Mapper.Map(teamDto, teamInDb);
            
         _context.SaveChanges();
      }
      [HttpDelete]
       public void DeleteTeam(int id)
       {
         var teamInDb = _context.Teams.SingleOrDefault(t => t.Id == id);
          if (teamInDb == null)
             throw new HttpResponseException(HttpStatusCode.NotFound);

          _context.Teams.Remove(teamInDb);
          _context.SaveChanges();
       }
    }

}
