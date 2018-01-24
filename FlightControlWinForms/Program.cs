using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace FlightControlWinForms
{
    static class Program
    {
        public static SqlConnection MyConnection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Data Source=op-projekt.database.windows.net;Initial Catalog=op;Integrated Security=False;User ID=mislav;Password=PassWord123;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"]);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainController mainController = new MainController();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainWindow(mainController));
        }
    }
}
