using System;
using System.Linq;
using System.Data.Entity;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new PlutoContext();

            var author = Context.Authors.Include(a=>a.Courses).Single(a=>a.Id==2);
            Context.Courses.RemoveRange(author.Courses);
            Context.Authors.Remove(author);
            Context.SaveChanges();



       }
    }
}
