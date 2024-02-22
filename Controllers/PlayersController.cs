using football_api.Helpers;
using football_api.Models;
using football_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace football_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayersController
{
    private readonly IPlayerService _playerService;
    
    public PlayersController(IPlayerService playerService)
    {
        _playerService = playerService;
    }
    
    [HttpGet]
    [Route("Get/{id}")]
    public string GetPlayer(int id)
    {
        _playerService.Get(id);
        return "";
    }

    [HttpGet]
    [Route("GetAll")]
    public string GetAll(int id)
    {
        _playerService.GetAll();
        return "";
    }

    [HttpPost]
    [Route("add")]
    public void AddPlayer(Player player)
    {
        _playerService.Add(player);
    }

    [HttpPost]
    [Route("Delete/{Player}")]
    public void DeletePlayer(int id)
    {
        _playerService.Delete(id);
    }

    [HttpPost]
    [Route("filter")]
    public void FilterPlayer(string item1 , int item2)
    {
        _playerService.FilterPlayer(item1 , item2);
    }

    [HttpPost]
    [Route("Update/{Player}")]
    public void UpdatePlayer(Player player , int id)
    {
        _playerService.Update(player, id);
    }

}