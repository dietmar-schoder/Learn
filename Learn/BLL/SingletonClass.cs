namespace Learn.BLL;

public interface ISingletonClass
{
    int ScopedIndex { get; set; }
    int SingletonIndex { get; set; }
    int TransientIndex { get; set; }
}

public class SingletonClass : ISingletonClass
{
    public int SingletonIndex { get; set; }

    public int ScopedIndex { get; set; }

    public int TransientIndex { get; set; }

    public SingletonClass()
        => SingletonIndex++;
}
