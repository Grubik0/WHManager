using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHManager.Classes
{
    public static class ErrorCheck
    {
        public static bool StringLengthCheck(int maxLength, string input)
        {
            if (input.Length <= maxLength) return true;
            else return false;
        }
    }
}
