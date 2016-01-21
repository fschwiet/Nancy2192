using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproNancyUrlIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Nancy.Url("/homepage"));
        }
    }
}
