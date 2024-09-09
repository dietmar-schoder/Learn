namespace Learn.BLL;

public interface IScopedClass
{
    void DoSomething();
}

public class ScopedClass : IScopedClass
{
    private readonly ILogger<ScopedClass> _logger;

    public ScopedClass(ISingletonClass singletonClass, ILogger<ScopedClass> logger)
    {
        _logger = logger;
        singletonClass.ScopedIndex++;
    }

    public void DoSomething()
    {
        _logger.Log(LogLevel.Information, $"{nameof(DoSomething)} was called.");
    }
}
