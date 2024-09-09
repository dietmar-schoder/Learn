using Learn.BLL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISingletonClass, SingletonClass>();
builder.Services.AddScoped<IScopedClass, ScopedClass>();
builder.Services.AddTransient<TransientClass, TransientClass>();

builder.Logging.ClearProviders();
builder.Logging.AddDebug();

var app = builder.Build();

app.MapGet("/", (ISingletonClass singletonClass, IScopedClass scopedClass, IScopedClass scopedClass2, TransientClass transientClass, TransientClass transientClass2) =>
{
    scopedClass.DoSomething();
    scopedClass2.DoSomething();
    return new List<int> { singletonClass.SingletonIndex, singletonClass.ScopedIndex, singletonClass.TransientIndex };
});

app.Run();
