using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new PlutoContext();
            IEnumerable<Course>courses=Context.Courses;
            var filtered = courses.Where(c => c.Level == 1);
            foreach(var fi in filtered)
            {
                Console.WriteLine(fi.Name);
            }
            

        }
    }
}
