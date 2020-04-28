using System;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new PlutoContext();
            var corses = Context.Courses;
            foreach(var c in corses)
            {
                Console.WriteLine(c.Name);
            }

        }
    }
}
