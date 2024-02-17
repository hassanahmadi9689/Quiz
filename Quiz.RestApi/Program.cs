using Quiz.Persistence.Ef;
using Quiz.Persistence.Ef.Player;
using Quiz.Persistence.Ef.Team;
using Quiz.Services.Player;
using Quiz.Services.Player.Contracts;
using Quiz.Services.Team;
using Quiz.Services.Team.Contracts;
using Taav.Contract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EfDataContext>();
builder.Services.AddScoped<PlayerServices, PlayerAppServices>();
builder.Services.AddScoped<PlayerRepository, EfPlayerRepository>();
builder.Services.AddScoped<UnitOfWork, EfUnitOfWork>();
builder.Services.AddScoped<TeamServices, TeamAppServices>();
builder.Services.AddScoped<TeamRepository, EfTeamRepository>();
builder.Services.AddScoped<UnitOfWork , EfUnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();