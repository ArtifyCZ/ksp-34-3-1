namespace KSP_34_3_1;

public class Input
{
    public readonly long n;

    public readonly IEnumerable<long> Tasks;

    private Input(long n, IEnumerable<long> tasks)
    {
        this.n = n;
        this.Tasks = tasks;
    }

    public static Input ReadInput()
    {
        var n = long.Parse(Console.ReadLine()!);

        var tasks = Console.ReadLine()!.Split(' ').Select(long.Parse);

        return new Input(n, tasks);
    }
}