﻿

using System.Diagnostics;

var numbers = Enumerable.Range(1, 10).ToList();


var evens = numbers.Where(n => n % 2 == 0);
numbers[0] = 8;


var nt = new NumberThing();
var sw = new Stopwatch();
var evens2 = nt.GetNumbers().Where(n => n % 2 == 0);
sw.Start();

foreach (var n in evens2)
{
    if (n == 10) break;
    Console.WriteLine(n);
}
sw.Stop();
Console.WriteLine($"That took {sw.ElapsedMilliseconds} milliseconds");



class NumberThing
{
    public IEnumerable<int> GetNumbers()
    {

        for (var t = 0; t < 100; t++)
        {
            Thread.Sleep(100);
            yield return t;
        }

    }
}