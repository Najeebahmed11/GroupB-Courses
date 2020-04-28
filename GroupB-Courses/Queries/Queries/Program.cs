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
            Context.Courses
                .Where(c => c.Level == 1)
                .OrderBy(a=>a.Name)
                .SelectMany(c=>c.Tags);

        }
    }
}
