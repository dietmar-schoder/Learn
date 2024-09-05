namespace Learn.DTO;

public class Result
{
    public int SingletonCalculatorIdentity { get; set; } = -1;

    public int SingletonManagerIdentity { get; set; } = -1;

    public int ScopedClassIdentity { get; set; } = -1;

    public int ScopedClass2Identity { get; set; } = -1;

    public int TransientClassIdentity { get; set; } = -1;

    public int TransientClass2Identity { get; set; } = -1;

    public int ScopedManagerIdentity { get; set; } = -1;
}
