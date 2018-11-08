using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace New_year_gifts
{
    static class Program
    {
        //private static Logger log = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewYearsGift());



            //private static Logger log = LogManager.GetCurrentClassLogger();      
            //log.Trace("trace message");
            //log.Debug("debug message");
            //log.Info("info message");
            //log.Warn("warn message");
            //log.Error("error message");
            //log.Fatal("fatal message");
        }
    }
}
