using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject;
using LoggerLib;
//using LogLib;

namespace AsynchronousChatUI
{
    public class Bindings: NinjectModule
    {
        public override void Load()
        {
            //Reference: http://blog.agilistic.nl/a-step-by-step-guide-to-using-ninject-for-dependancy-injection-in-c-sharp/

            Bind<ILoggingService>().To<Logger>().WithConstructorArgument("Logs/" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt");
            //Bind<ILoggingService>().To<NLogLogger>().WithConstructorArgument("Logs/" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt");
        }
    }
}
