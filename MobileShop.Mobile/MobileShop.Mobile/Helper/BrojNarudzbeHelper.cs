using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Mobile.Helper
{
    public class BrojNarudzbeHelper
    {
       
        public static string GenerisiBrojNarudzbe()
        {
           
            int trenutnibroj = 1;

            string novi = "N";

            if (trenutnibroj < 10)
            {
                novi += "00" + trenutnibroj;
            }
            else if(trenutnibroj<100 && trenutnibroj > 9)
            {
                novi += "0" + trenutnibroj;
            }
            else
            {
                novi += trenutnibroj;
            }

            trenutnibroj++;
          
            return novi;
        }
    }
}
