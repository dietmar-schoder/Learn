using Learn.DTO;

namespace Learn.BLL;

public interface ISingletonManager
{
    Result GetResult();
}

public class SingletonManager : ISingletonManager
{
    private readonly ISingletonCalculator _singletonCalculator;

    public int Identity { get; set; }

    public SingletonManager(
        ISingletonCalculator singletonCalculator)
    {
        _singletonCalculator = singletonCalculator;
        Identity = _singletonCalculator.GetNextValue();
    }

    public Result GetResult()
        => new()
        {
            SingletonCalculatorIdentity = _singletonCalculator.Identity,
            SingletonManagerIdentity = Identity
        };
}
