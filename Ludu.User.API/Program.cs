using Ludu.User.API;
using Ludu.User.API.Middleware;
using Ludu.User.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
        .AddApi(builder.Configuration)
        .AddApplication();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseApi();

app.Run();
