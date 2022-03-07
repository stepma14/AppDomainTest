using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AppDomainTest
{
   [TestFixture]
    internal class MyTestBase //tohle je jako CollectorTestsBase
    {
        //tohle je v podstate protected void StartCollector() => _collectorService.RunInConsole(false); z CollectorTestsBase
        public void MyStuff()
        {
            CollectorService cs = new CollectorService();
            cs.DoSomething();
        }
    }
}
