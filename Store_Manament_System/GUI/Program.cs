using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.DTO;
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
            AppSession.CurrentUser = new UserDTO
            {
                userID = 4,
                userName = "Admin"
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainSaleForm());
        }
    }
}
