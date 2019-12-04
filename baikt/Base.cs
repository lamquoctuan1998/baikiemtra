using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikt
{
    class Base
    {
        public static String ma;
        public static String getMa()
        {
            Random temp = new Random();
            String st = temp.Next(100000, 999999).ToString();
            ma = "SV" + st;
            return ma;
        }
        
    }
}
