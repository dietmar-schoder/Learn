namespace Learn.BLL;

public class TransientClass
{
    public TransientClass(ISingletonClass singletonClass)
    {
        singletonClass.TransientIndex++;
    }
}
