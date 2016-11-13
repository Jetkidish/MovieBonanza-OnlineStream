using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_OnlineStream
{
    static class Program
    {
        // selection array stores the information on the users selection, including the movie title, cost, and category
        public static string[] selection = new string[3];
        // the double 'cost' is a global variable for the grandtotal calculated in the order form
        public static double cost;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
