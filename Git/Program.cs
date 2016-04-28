using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    public class Program
    {
        /// <summary>
        /// Add summary
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git");
            Console.WriteLine("this is change by others pull request");
            Console.WriteLine("Commit 1");
            Console.WriteLine("Commit 2");
            Console.WriteLine("Commit 3");
            Console.WriteLine("this only reflect when pull");
            Console.WriteLine("test with pull, this change is commited but i am not using sync here. sync do push and pull both that i don't want.");
            Console.WriteLine("Revision for commit 4");
        }
    }
}
