using System.Collections.Immutable;

namespace KSP_34_3_1;

public static class LambdaExtensions
{
    public static IEnumerable<T> RepeatTimes<T>(Func<long, T> x, long n)
    {
        for (long i = 0; i < n; i++)
        {
            yield return x(i);
        }
    }

    public static IEnumerable<T> RepeatTimesApply<T>(Func<long, T> x, long n)
        => RepeatTimes(x, n).ToImmutableList();
}