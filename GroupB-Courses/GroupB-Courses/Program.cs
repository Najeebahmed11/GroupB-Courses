using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupB_Courses
{
    class Program
        {
        static void Main(string[] args)
        {
            var context = new TestDatabaseToDeleteEntities();
            var post = new TestTable()
            {
                Id=123,
                Name = "naje"

            };
            context.TestTables.Add(post);
            context.SaveChanges();
        }
    }
    
}
