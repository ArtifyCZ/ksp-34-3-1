namespace KSP_34_3_1;

public static class EnumerableExtensions
{
    public static IEnumerable<IEnumerable<T>> CustomGroup<T>(this IEnumerable<T> list, Func<T?, T, bool> predicate)
    {
        T? prev = default;

        var actualList = new LinkedList<T>();
        
        foreach (var x in list)
        {
            if (prev != null && !predicate(prev, x))
            {
                yield return actualList;
                actualList = new LinkedList<T>();
            }
            
            actualList.AddLast(x);
            
            prev = x;
        }

        yield return actualList;
    }

    public static IEnumerable<long> CustomSort(this IEnumerable<long> list)
    {
        var s = new Stack<long>();

        foreach (var item in list)
        {
            var first = s.FirstOrDefault();
        
            if (first == default)
            {
                s.Push(item);
                continue;
            }

            if (item < first)
            {
                s.Push(item);
                continue;
            }
            else
            {
                while (item >= s.FirstOrDefault() && 0 < s.Count)
                {
                    yield return s.Pop();
                }
                
                s.Push(item);
            }
        }

        while (0 < s.Count)
        {
            yield return s.Pop();
        }
    }
}