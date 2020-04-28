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
            
            var course = new Course
            {
                Name = "new Course 2",
                Description = "new Description",
                FullPrice=19.95f,
                Level=1,
                AuthorId=1
            };
            Context.Courses.Add(course);
            Context.SaveChanges();
       }
    }
}
