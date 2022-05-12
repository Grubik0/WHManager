using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHManager.Classes
{
    public static class ErrorCheck
    {
        public static bool StringLengthCheckMax(int maxLength, string input)
        {
            if (input.Length <= maxLength) return true;
            else return false;
        }

        public static bool StringLengthCheckTotal(int maxLength, string input)
        {
            if (input.Length == maxLength) return true;
            else return false;
        }
    }
}
