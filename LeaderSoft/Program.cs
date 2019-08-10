using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LeaderSoft.Forms.PublicForms;

namespace LeaderSoft
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
            Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new FormTypeAcc());
            //Application.Run(new FormSelesMan());
            //Application.Run(new FormCostCenter());
            //Application.Run(new Formcurency());
            //Application.Run(new FormSuppliers());
            //Application.Run(new FormCustomers());
            //Application.Run(new FormHustingCauseways());
            //Application.Run(new FormDebentures());
            //Application.Run(new FormConcludingAcconuts());
            //Application.Run(new FormFund());
            //Application.Run(new FormAcconutsTypes());
            //Application.Run(new FormChatOfAccount());
            //Application.Run(new FormBranches());
            //Application.Run(new FormBanks());
            //Application.Run(new Form1());
        }
    }
}
