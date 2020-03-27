using MobileShop.WinUI.Zahtjevi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShop.WinUI.Helper;

namespace MobileShop.WinUI
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

            

            frmLogin login = new frmLogin();
            if(login.ShowDialog()==DialogResult.OK)
            {
                
                if (Global.Admin==true && Global.Prodavac==false)
                {
                    Application.Run(new frmIndexAdmin());
                }
                else if(Global.Admin==false && Global.Prodavac==true)
                {
                    Application.Run(new frmIndex());
                }
                else
                {
                    Application.Run(new frmIndexAdmin());
                }


              
                
               
            }
                
        }
    }
}
