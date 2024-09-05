namespace Learn.BLL;

public interface IScopedClass
{
    int Identity { get; set; }
}

public class ScopedClass(ISingletonCalculator singletonCalculator) : IScopedClass
{
    public int Identity { get; set; } = singletonCalculator.GetNextValue();
}
