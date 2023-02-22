using System.Collections.Immutable;
using KSP_34_3_1;

var input = Input.ReadInput();

var x = input.Tasks
    // .CustomGroup((prev, x) => prev >= x)
    // .Select(x => x.Reverse())
    // .SelectMany(y => y)
    // .ToList();
    .CustomSort()
    .ToImmutableList();

long a = 0;
long b = 0;

x.ForEach(y =>
{
    if (a <= b)
    {
        a += y;
    }
    else
    {
        b += y;
    }
});

Console.WriteLine(Math.Max(a, b));