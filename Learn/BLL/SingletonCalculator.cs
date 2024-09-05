namespace Learn.BLL;

public interface ISingletonCalculator
{
    int Identity { get; set; }
    int GetNextValue();
}

public class SingletonCalculator : ISingletonCalculator
{
    private int highestValue;

    public int Identity { get; set; }

    public SingletonCalculator()
        => Identity = GetNextValue();

    public int GetNextValue()
        => highestValue++;
}
