namespace Learn.BLL;

public interface ITransientClass
{
    int Identity { get; set; }
}

public class TransientClass(ISingletonCalculator singletonCalculator) : ITransientClass
{
    public int Identity { get; set; } = singletonCalculator.GetNextValue();
}
