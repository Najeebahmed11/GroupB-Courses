using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        void Process(IEnumerable<Human> people)
        {
            var ppl = people as IList<Human> ?? people.ToList();
            var kids = ppl.Where(p => p.Age < 13);
            var numberOfTeens = ppl.Count(p => p.Age >= 13 && p.Age <= 19);
        }

        IEnumerable<Human> GetTeenagersNamedAdam(IEnumerable<Human> people)
        {
            var result = new List<Human>();
            foreach (var p in people)
            {
                if (p.Age >= 13 && p.Age <= 19)
                    if (p.Name == "Adam")
                        result.Add(p);
            }
            return result;
        }

        void XmlDemo()
        {
            var x = new XElement("foo", new XElement("bar")).ToString();
        }

        static void Main(string[] args)
        {
        }
    }

    public class Human
    {
        public string Name;
        public int Age;
    }
}
