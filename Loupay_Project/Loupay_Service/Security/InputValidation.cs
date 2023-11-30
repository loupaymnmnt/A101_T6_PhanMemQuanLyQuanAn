using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Service.Security
{
    public static class InputValidation
    {
        public static bool IsQualifiedInputString(int minimumRequiredLength, params string[] inputString)
        {
            foreach (string str in inputString)
            {
                if (str.Length < minimumRequiredLength)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsOnlyDigitString(string inputString)
        {
            foreach (char c in inputString)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
