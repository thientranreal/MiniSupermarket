using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MiniSupermarket.RegularExpression
{
    internal class ProjectRegex
    {
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }

        public static bool IsPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(0|84|\+84)(3[2-9]|5[689]|7[06-9]|8[1-689]|9[0-46-9])\d{7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }

    }
}
