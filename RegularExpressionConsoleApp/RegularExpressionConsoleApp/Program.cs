using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches("大家好，我是Hebe，我22岁了，身高180，我们团队有3个女女！", @"大家|我是|HE|女女|扑街|去死",RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
