using football_api.Database.Interface;
using football_api.Models;
using Newtonsoft.Json;
using System.IO;

namespace football_api.Database;

public class Database<T> : IDatabase<T>
{
    
    public void Add<T>(T item, string path)
    {
        var content = File.ReadAllText(path);
        List<T> items = JsonConvert.DeserializeObject<List<T>>(content);
        
        items.Add(item);
        string json = JsonConvert.SerializeObject(items);
        File.WriteAllText(path, json);

    }

    public void Delete<T>(int id , string path)

    {
        var content = File.ReadAllText(path);
        List<Player> players = JsonConvert.DeserializeObject<List<Player>>(content);

        Player playerToDelete = players.FirstOrDefault(p => p.Id == id);
        
            players.Remove(playerToDelete);

        string json = JsonConvert.SerializeObject(players);
        File.WriteAllText(path, json);
    }

    public void FilterPlayer(string item1 , int item2 , string path)
    {
        var content = File.ReadAllText(path);
        List<Player> players = JsonConvert.DeserializeObject<List<Player>>(content);

        var filteredBy = players.Where(p => p.Name.Contains(item1) && p.age == item2);
        var filteredBy2 = players.Where(p => p.Name.Contains(item1));
    }

    public void GetAll<T>(string path)
    {
        var content = File.ReadAllText(path);
        List<Player> players = JsonConvert.DeserializeObject<List<Player>>(content);

        List<Player> playerToFind = players.Where(p => p.Id >= 0).ToList();
    }

    public void Get<T>(int id , string path)
    {

        var content = File.ReadAllText(path);
        List<Player> players = JsonConvert.DeserializeObject<List<Player>>(content);

        Player playerToFind = players.FirstOrDefault(p => p.Id == id);

    }

    public void Update<T>(T item , int id , string path)
    {

        var content = File.ReadAllText(path);
        List<Player> players = JsonConvert.DeserializeObject<List<Player>>(content);

        Player playerToFind = players.FirstOrDefault(p => p.Id == id);

        playerToFind.Name = ((Player)(object)item).Name;
        playerToFind.age = ((Player)(object)item).age;
        playerToFind.Nationality = ((Player)(object)item).Nationality;

    }
}