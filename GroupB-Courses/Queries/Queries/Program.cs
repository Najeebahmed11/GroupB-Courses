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
            var query =
                from a in Context.Authors
                join c in Context.Courses on a.Id equals c.Author.Id into g
                select new { AuthorName = a.Name, Courses = g.Count() };
            foreach(var x in query)
            {
                Console.WriteLine("{0}({1})", x.AuthorName, x.Courses);
            }
        }
    }
}
