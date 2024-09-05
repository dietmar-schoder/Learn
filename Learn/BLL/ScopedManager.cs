using Learn.DTO;

namespace Learn.BLL;

public interface IScopedManager
{
    Result GetResult();
}

public class ScopedManager : IScopedManager
{
    private readonly ISingletonCalculator _singletonCalculator;
    private readonly IScopedClass _scopedClass;
    private readonly IScopedClass _scopedClass2;
    private readonly ITransientClass _transientClass;
    private readonly ITransientClass _transientClass2;

    public int Identity { get; set; }

    public ScopedManager(
        ISingletonCalculator singletonCalculator,
        IScopedClass scopedClass,
        IScopedClass scopedClass2,
        ITransientClass transientClass,
        ITransientClass transientClass2)
    {
        _singletonCalculator = singletonCalculator;
        _scopedClass = scopedClass;
        _scopedClass2 = scopedClass2;
        _transientClass = transientClass;
        _transientClass2 = transientClass2;
        Identity = _singletonCalculator.GetNextValue();
    }

    public Result GetResult()
        => new()
        {
            SingletonCalculatorIdentity = _singletonCalculator.Identity,
            ScopedClassIdentity = _scopedClass.Identity,
            ScopedClass2Identity = _scopedClass2.Identity,
            TransientClassIdentity = _transientClass.Identity,
            TransientClass2Identity = _transientClass2.Identity,
            ScopedManagerIdentity = Identity
        };
}
