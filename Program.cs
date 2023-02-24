using Pawcare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var startup = new Startup(builder.Configuration);

startup.configureServices(builder.Services);


var app = builder.Build();

startup.configure(app, app.Environment);

// Configure the HTTP request pipeline.


app.Run();
