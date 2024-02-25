using football_api.Models;

namespace football_api.Services.Interfaces
{
    public interface ITeamService
    {
            public void Add(Team team);

            public void Delete(int id);

            public void FilterTeam(string item1, int item2);

            public void GetAll();

            public void Get(int id);

            public void Update(Team team, int id);
        
    }
}
