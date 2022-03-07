using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AppDomainTest
{
    
    internal class CollectorTest : CollectorTestsBase
    {

        [Test]
        public void RunCollector()
        {
            Console.WriteLine("\nDomain in MyTest.cs");
            Console.WriteLine("Object is executing in AppDomain \"{0}\"",
            AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Base directory is: {0}", AppDomain.CurrentDomain.BaseDirectory);

            StartCollector();

        }
    }
}
