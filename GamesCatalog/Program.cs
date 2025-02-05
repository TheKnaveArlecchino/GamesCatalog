using GamesCatalog.Interfaces;
using GamesCatalog.Repositories;
using GamesCatalog.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Bson;
using MongoDB.Driver;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IGameService, GameService>();


const string connectionUri = "mongodb+srv://ladyofworlds:<Dqx45oRMTHnQBIDv>@cluster0.tgtfu.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

var settings = MongoClientSettings.FromConnectionString(connectionUri);

settings.ServerApi = new ServerApi(ServerApiVersion.V1);

var client = new MongoClient(settings);

try
{
    var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
    Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
