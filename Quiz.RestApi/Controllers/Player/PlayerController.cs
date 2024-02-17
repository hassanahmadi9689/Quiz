using Microsoft.AspNetCore.Mvc;
using Quiz.Services.Player.Contracts;
using Quiz.Services.Player.Dtos;

namespace Quiz.RestApi.Controllers.Player;
[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private readonly PlayerServices _services;

    public PlayerController(PlayerServices services)
    {
        _services = services;
    }
    
    [HttpPost]
    public async Task Add(AddPlayerDto dto)
    {
        await _services.Add(dto);
    }

    [HttpGet]
    public List<GetPlayerDto> GetByAge([FromQuery]GetFilterPlayerDto dto)
    {
       return _services.GetPlayerBySearch(dto);
    }
}