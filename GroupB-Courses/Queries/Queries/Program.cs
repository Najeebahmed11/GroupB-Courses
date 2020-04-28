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
            var authors = Context.Authors.Single(a=>a.Id==1);
            Context.Entry(authors).Collection(a => a.Courses).Query().Where(c=>c.FullPrice==0).Load();
            Context.Courses.Where(c => c.AuthorId == authors.Id && c.FullPrice==0).Load();
            foreach(var course in authors.Courses)
            {
                Console.WriteLine("{0} by {1}", course.Name, course.Author.Name);
            }
            

        }
    }
}
