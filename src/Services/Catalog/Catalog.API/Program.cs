var builder = WebApplication.CreateBuilder(args);

//add services to the container.
builder.Services.AddCarter(new DependencyContextAssemblyCatalog([typeof(Program).Assembly]));
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

//configure the HTTP request pipeline
app.MapCarter();

app.Run();
