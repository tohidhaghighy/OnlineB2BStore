using FastEndpoints;
using FastEndpoints.Swagger;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Domain.Db;
using OnlineB2BStoreBackend.Infrastructure.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddFastEndpoints().AddResponseCaching()
   .SwaggerDocument(); //define a swagger document
builder.Services.AddSingleton<ApplicationDbContext>();
builder.Services.AddScoped<IMenuGroupService,MenuGroupService>();

// Configure JSON serialization options to ignore null properties
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

var app = builder.Build();

// Configure FastEndpoints in the app
app.UseResponseCaching().UseFastEndpoints()
   .UseSwaggerGen(); //add this;

app.UseAuthorization();

app.MapControllers();

app.Run();
