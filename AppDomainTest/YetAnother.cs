using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainTest
{
    static class YetAnother
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("myotherlog");
        
        public static void JustDoIt()
        {
            log.Info("justdoit");
        }
    }
}
