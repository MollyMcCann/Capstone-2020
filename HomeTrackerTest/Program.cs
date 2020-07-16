using HomeTrackerDatamodelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeTrackerTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       // [STAThread]
        [System.STAThreadAttribute]
        static void Main()
        {
            try
            {
                CreateAndInitializeDB.CreateAndInitializeDatabase();
                // App.Main();
            }
            catch (Exception ex)
            {
                //TODO 1: Log errors
                MessageBox.Show("An error occurred! " + ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
