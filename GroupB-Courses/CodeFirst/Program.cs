using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.AccessControl;
using System.Threading;

namespace CodeFirst
{
    public class PlutoContext: DbContext
    {
        public DbSet<Cours> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public PlutoContext()
            :base("name=DefaultConnection")
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
