using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //meta deta :refer to assemblies  
            var dbContext = new PlutoDbContext();
            var courses=dbContext.GetCourses();
            foreach (var cou in courses)
            {
                Console.WriteLine(cou.Title);
            }
            dbContext.GetAuthorCourses;
        }
    }
}
