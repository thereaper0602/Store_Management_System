using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UI_SALE;
using GUI.Utils;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Test thử AppSession
            AppSession.CurrentUser = new DTO.DTO.UserDTO
            {
                userID = 1,
                username = "admin",
                password = "admin",
                roleID = 1
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainSaleForm());
        }
    }
}
