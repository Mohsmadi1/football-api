using football_api.Database.Interface;
using football_api.Models;
using football_api.Services.Interfaces;

namespace football_api.Services;

public class PlayerService : IPlayerService
{
    private readonly IDatabase<Player> _database;
    private readonly IIndexManager _indexManager;

    public PlayerService(IDatabase<Player> database, IIndexManager indexManager)
    {
        _database = database;
        _indexManager = indexManager;
    }
    
    public void Add(Player player)
    {
        string playerPath = "./Data/Players/players.json";

        var id = _indexManager.Get("./Data/Players/index.txt");

         id = id + 1;

        _indexManager.Update(id, playerPath);

        player.Id = id;

        _database.Add(player , playerPath);

    }

    public void Delete(int id)
    {
        string playerPath = "./Data/Players/players.json";
        _database.Delete<int>(id , playerPath);
    }

    public void FilterPlayer(string item1 , int item2)
    {
        string playerPath = "./Data/Players/players.json";
        _database.FilterPlayer(item1 , item2 , playerPath);
    }
    public void GetAll()
    {
        string playerPath = "./Data/Players/players.json";
        _database.GetAll<int>(playerPath);
    }

    public void Get(int id)
    {

        string playerPath = "./Data/Players/players.json";
        _database.Get<int>(id, playerPath);

    }

    public void Update(Player player, int id)
    {

        string playerPath = "./Data/Players/players.json";
        _database.Update<Player>(player , id , playerPath);

    }
}