using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsynchronousChatLib;
using Microsoft.Practices.Unity;
using LoggerLib;
using Ninject.Modules;
using Ninject;
using System.Reflection;
//using LogLib;

namespace AsynchronousChatUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_NetworkGame(new Client(new Logger(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt"))));

            //Using Microsoft Unity Container
            UnityContainer container = new UnityContainer();
            container.RegisterType<ILoggingService, Logger>(new InjectionConstructor(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt"));
            Application.Run(container.Resolve<Form_NetworkGame>());

            //Using Ninject
            //Reference: http://blog.agilistic.nl/a-step-by-step-guide-to-using-ninject-for-dependancy-injection-in-c-sharp/
            //IKernel kernel = new StandardKernel();
            //kernel.Load(Assembly.GetExecutingAssembly());
            //Application.Run(new Form_NetworkGame(new Client(kernel.Get<ILoggingService>())));

            //Using Colin Fenton's LogLib project
            //Using Microsoft Unity Container
            //UnityContainer container = new UnityContainer();
            //container.RegisterType<ILoggingService, Logger>();
            //Application.Run(container.Resolve<Form_NetworkGame>());

        }

    }
}
