using Learn.BLL;
using Learn.DTO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISingletonCalculator, SingletonCalculator>();
builder.Services.AddSingleton<ISingletonManager, SingletonManager>();
builder.Services.AddScoped<IScopedClass, ScopedClass>();
builder.Services.AddTransient<ITransientClass, TransientClass>();
builder.Services.AddScoped<IScopedManager, ScopedManager>();

var app = builder.Build();

app.MapGet("/", (ISingletonManager singletonManager, IScopedManager scopedManager) =>
{
    return new List<Result> { singletonManager.GetResult(), scopedManager.GetResult() };
});

app.Run();
