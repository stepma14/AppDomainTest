using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AppDomainTest
{
   [TestFixture]
    public class CollectorTestsBase
    {
      
        CollectorService cs = new CollectorService();
        //tohle je v podstate protected void StartCollector() => _collectorService.RunInConsole(false); z CollectorTestsBase
        protected void StartCollector() => cs.DoSomething();
    }
}
