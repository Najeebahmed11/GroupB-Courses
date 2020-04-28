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
            var corses=Context.Courses.Skip(10).Take(10);

        }
    }
}
