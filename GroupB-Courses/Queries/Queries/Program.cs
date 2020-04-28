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

            var course = Context.Courses.Find(4);
            course.Name = "New Name";
            course.AuthorId = 2;
            
            Context.SaveChanges();
       }
    }
}
