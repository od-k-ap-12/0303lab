using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _0303lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7
            string IP = @"^(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])$";
            Console.WriteLine("Enter an IPv4: ");
            Console.WriteLine(new Regex(IP).IsMatch(Console.ReadLine()) ? "Valid IP" : "Invalid IP");
            #endregion

            #region 8
            string CheckVowels = @"[aeiouy]";
            Console.WriteLine("Enter a string: ");
            MatchCollection mc = new Regex(CheckVowels).Matches(Console.ReadLine());
            int VowelCount = 0;
            foreach (Match match in mc)
            {
                VowelCount++;
            }
            Console.WriteLine(VowelCount);
            #endregion

            #region 9
            string URL = @"^(http://|https://)?(www.)?[a-zA-Z]+\.[a-zA-Z]+$";
            Console.WriteLine("Enter a URL: ");
            Console.WriteLine(new Regex(URL).IsMatch(Console.ReadLine()) ? "Valid URL" : "Invalid URL");
            #endregion

            #region 10
            string wCheck = @"\w+";
            Console.WriteLine("Enter a string: ");
            Console.WriteLine(new Regex(wCheck).IsMatch(Console.ReadLine()) ? "Yes" : "No");
            #endregion

            #region 11
            string Time = @"^(([01][0-9])|([2][0-3]))(:|\.)[0-5][0-9]$";
            Console.WriteLine("Enter time: ");
            Console.WriteLine(new Regex(Time).IsMatch(Console.ReadLine()) ? "Valid time" : "Invalid time");
            #endregion

            #region 12
            string PostIndex = @"^\d{5}$";
            Console.WriteLine("Enter a post index: ");
            Console.WriteLine(new Regex(PostIndex).IsMatch(Console.ReadLine()) ? "Valid index" : "Invalid index");
            #endregion
        }
    }
}
