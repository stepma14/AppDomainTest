using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object is executing in AppDomain \"{0}\"",
           AppDomain.CurrentDomain.FriendlyName);
        }
    }
}
