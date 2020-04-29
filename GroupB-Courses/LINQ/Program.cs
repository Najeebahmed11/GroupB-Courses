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
            var numbers = Enumerable.Range(1, 20).ToArray();
            var results = numbers.AsParallel()
                .WithMergeOptions(ParallelMergeOptions.NotBuffered)
                .Select(x =>
                {
                    var result = Math.Log10(x);
                    Console.Write($"prodeuced{result}\t");
                    return result;
                });
            foreach (var result in results)
            {
                Console.Write($"consummed:{result}\t");
            }
        }
    }
}
