using football_api.Models;

namespace football_api.Services.Interfaces;

public interface IPlayerService
{
    public void Add(Player player);

    public void Delete(int id);

    public void FilterPlayer(string item1 , int item2);

    public void GetAll();

    public void Get(int id);

    public void Update(Player player, int id);
}