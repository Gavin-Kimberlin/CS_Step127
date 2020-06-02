using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step127
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This ";
            string s2 = "is a ";
            string s3 = "string.\n";
            Console.WriteLine(s1 + s2 + s3);


            string lower = "uppercase\n";
            Console.WriteLine(lower.ToUpper());

            StringBuilder sb = new StringBuilder("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do ", 400);
            sb.Append("eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut ");
            sb.Append("enim ad minim veniam, quis nostrud exercitation ullamco laboris ");
            sb.Append("nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in ");
            sb.Append("reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla ");
            sb.Append("pariatur. Excepteur sint occaecat cupidatat non proident, sunt in ");
            sb.Append("culpa qui officia deserunt mollit anim id est laborum.");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
