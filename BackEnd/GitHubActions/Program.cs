var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var configurationBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

if (builder.Environment.IsDevelopment())
{
    configurationBuilder
        .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
        .AddUserSecrets<Program>();
}
    
var configuration = configurationBuilder
    .AddEnvironmentVariables()
    .Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();