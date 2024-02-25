using football_api.Database.Interface;
using football_api.Models;
using football_api.Services.Interfaces;

namespace football_api.Services;

public class TeamsService
{
    private readonly IDatabase<Team> _database;
    private readonly IIndexManager _indexManager;

    public TeamsService(IDatabase<Team> database, IIndexManager indexManager)
    {
        _database = database;
        _indexManager = indexManager;
    }

    public void Add(Team team)
    {
        string TeamPath = "./Data/Teams/teams.json";

        var id = _indexManager.Get("./Data/Teams/index.txt");

        id = id + 1;

        _indexManager.Update(id, TeamPath);

        team.Id = id;

        _database.Add(team, TeamPath);

    }

    public void Delete(int id)
    {
        string TeamPath = "./Data/Teams/teams.json";
        _database.Delete<int>(id, TeamPath);
    }

    public void FilterPlayer(string item1, int item2)
    {
        string TeamPath = "./Data/Teams/teams.json";
        _database.FilterPlayer(item1, item2, TeamPath);
    }
    public void GetAll()
    {
        string TeamPath = "./Data/Teams/teams.json";
        _database.GetAll<int>(TeamPath);
    }

    public void Get(int id)
    {

        string TeamPath = "./Data/Teams/teams.json";
        _database.Get<int>(id, TeamPath);

    }

    public void Update(Team team, int id)
    {

        string TeamPath = "./Data/Teams/teams.json";
        _database.Update<Team>(team, id, TeamPath);

    }
}