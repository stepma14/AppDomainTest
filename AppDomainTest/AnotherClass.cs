using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net;

namespace AppDomainTest
{
    
    public class AnotherClass : MarshalByRefObject
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void DoIt()
        {
            BasicConfigurator.Configure();
            Console.WriteLine("\nDomain in AnotherClass.cs");
            Console.WriteLine("Object is executing in AppDomain \"{0}\"",
            AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Base directory is: {0}", AppDomain.CurrentDomain.BaseDirectory);

            Console.Write("Im doing it");
            log.Debug("im doing it, chill....");
            YetAnother.JustDoIt();
        }
    }
}
