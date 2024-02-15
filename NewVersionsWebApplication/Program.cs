using NewVersionsWebApplication.Handlers;
using NewVersionsWebApplication.Services.Abstract;
using NewVersionsWebApplication.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Keyed Service | Dependency Injection
builder.Services.AddKeyedScoped<IDeveloperService, FrontendDeveloperService>("frontend");
builder.Services.AddKeyedScoped<IDeveloperService, BackendDeveloperService>("backend");
#endregion

#region IExceptionHandler
builder.Services.AddExceptionHandler<ExceptionHandler>();
builder.Services.AddProblemDetails();
#endregion

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

#region IExceptionHandler
app.UseExceptionHandler();

app.MapGet("/exception", () =>
{
    throw new Exception("Hata mesaji");
});

#endregion

#region Keyed Service | ShortCircut
app.MapGet("/", ([FromKeyedServices("frontend")] IDeveloperService developerService) =>
{
    return developerService.GetDeveloperType;
}).ShortCircuit();


using var scope = app.Services.CreateScope();
var developerService = scope.ServiceProvider.GetKeyedService<IDeveloperService>("backend");

Console.WriteLine(developerService.GetDeveloperType);
#endregion




app.Run();
