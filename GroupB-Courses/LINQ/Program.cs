using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            // Console.WriteLine(evenNumbers);

            // combine projection and filtering
            var Evenquares = evenNumbers.Select(x => x * x);
            //Console.WriteLine(Evenquares);
            var Remove = Evenquares.Where(y => y < 50);
            Console.WriteLine(Remove);




        }
    }
}
