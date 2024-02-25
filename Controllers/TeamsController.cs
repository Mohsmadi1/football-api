using football_api.Models;
using football_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace football_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController
    {
        private readonly ITeamService _TeamService;

        public TeamsController(ITeamService TeamService)
        {
            _TeamService = TeamService;
        }

        [HttpGet]
        [Route("Get/{id}")]
        public string GetTeam(int id)
        {
            _TeamService.Get(id);
            return "";
        }

        [HttpGet]
        [Route("GetAll")]
        public string GetAll(int id)
        {
            _TeamService.GetAll();
            return "";
        }

        [HttpPost]
        [Route("add")]
        public void AddTeam(Team team)
        {
            _TeamService.Add(team);
        }

        [HttpPost]
        [Route("Delete/{Team}")]
        public void DeletePlayer(int id)
        {
            _TeamService.Delete(id);
        }

        [HttpPost]
        [Route("filter")]
        public void FilterTeam(string item1, int item2)
        {
            _TeamService.FilterTeam(item1, item2);
        }

        [HttpPost]
        [Route("Update/{Team}")]
        public void UpdateTeam(Team team, int id)
        {
            _TeamService.UpdateTeam(team, id);
        }
    }
}
