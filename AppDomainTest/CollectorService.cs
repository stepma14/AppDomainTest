using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace AppDomainTest
{
    public class CollectorService
    {
        private AppDomain serviceAppDomain = null;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void DoSomething()
        {
            BasicConfigurator.Configure();
            AnotherClass cs = new AnotherClass();
            AppDomainSetup setup = new AppDomainSetup
            {
                ApplicationName = "something",
                ApplicationBase = AppDomain.CurrentDomain.BaseDirectory,
                ShadowCopyFiles = "false",
            };


            Evidence baseEvidence = AppDomain.CurrentDomain.Evidence;
            Evidence evidence = new Evidence(baseEvidence);

            serviceAppDomain = AppDomain.CreateDomain("test", evidence, setup);
            log.Error("Hm, error");
          //  serviceAppDomain.UnhandledException += CurrentDomain_UnhandledException;

            cs = (AnotherClass)serviceAppDomain.CreateInstanceAndUnwrap(typeof(AnotherClass).Assembly.FullName, typeof(AnotherClass).FullName);
            cs.DoIt();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;

            log.Fatal("Unhandled exception caught.", ex);
            log.Fatal("Unhandled inner exception caught.", ex?.InnerException);
        }

    }

}
