using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainTest
{
    internal class CollectorService
    {
        private AppDomain serviceAppDomain = null;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("mylog");
        public void DoSomething()
        {
            AnotherClass cs = new AnotherClass();
            //vytvori si domenu podobne jako CollectorService v SolarWinds
            AppDomainSetup setup = new AppDomainSetup
            {
                ApplicationName = "something",
                ApplicationBase = AppDomain.CurrentDomain.BaseDirectory,
                ShadowCopyFiles = "false",
            };


            Evidence baseEvidence = AppDomain.CurrentDomain.Evidence;
            Evidence evidence = new Evidence(baseEvidence);

            serviceAppDomain = AppDomain.CreateDomain("test", evidence, setup);
            cs = (AnotherClass)serviceAppDomain.CreateInstanceAndUnwrap(typeof(AnotherClass).Assembly.FullName, typeof(AnotherClass).FullName);
            cs.DoIt();
        }

    }

}
