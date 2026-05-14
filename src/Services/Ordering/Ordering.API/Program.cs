using Ordering.API;
using Ordering.Application;
using Ordering.Infastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplicationServices()
    .AddInfastructureServices(builder.Configuration)
    .AddApiServices();

var app = builder.Build();




app.Run();