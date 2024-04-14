using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Input
    {
        public static int IntNumber(string number)
        {
            bool ok;
            int output;
            do
            {
                ok = int.TryParse(number, out output);
                if (ok)
                {
                    ok = false;
                }
            } while (!ok);
            return output;
        }
       
    }
}
