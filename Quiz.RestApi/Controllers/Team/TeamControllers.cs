using Microsoft.AspNetCore.Mvc;
using Quiz.Services.Team.Contracts;
using Quiz.Services.Team.Dtos;

namespace Quiz.RestApi.Controllers.Team;
[ApiController]
[Route("[controller]")]
public class TeamControllers : ControllerBase
{
    private readonly TeamServices _services;

    public TeamControllers(TeamServices services)
    {
        _services = services;
    }

    [HttpPost]
    public async Task Add(AddTeamDto dto)
    {
        await _services.Add(dto);
    }

    [HttpGet("Get-By-Search")]
    public List<GetTeamDto> Get([FromQuery]GetTeamFilterDto dto)
    {
       return _services.GetTeam(dto);
    }
}