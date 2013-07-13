using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Logging;
using ServiceStack.Logging.Log4Net;

namespace IrisAccess
{
    static class Program
    {
        public static Funq.Container Container { get; set; }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogManager.LogFactory = new Log4NetFactory(@"\_config\log4net\log4net.xml");

            Container = new Funq.Container();
            Container.InitializeContainer();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
