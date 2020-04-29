using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = ParallelEnumerable.Range(1, 1000)
                .Aggregate(
                 0,
                 (partialsum, i) => partialsum += i,
                 (total, subtotal) => total += subtotal,
                 i => i);
            Console.WriteLine($"sum:{sum}");

        }
    }
}
