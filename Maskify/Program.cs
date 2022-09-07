using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maskify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("1111111135616"));
            Console.ReadLine();
        }

        public static string Maskify(string cc)
        {
            char[] chars = cc.ToCharArray();
            string result = "";
            if (cc == "1" || cc == " ")
            {
                return cc;
            }

            if (cc.Length == 4)
            {
                return cc;
            }

            int i = 0;
            while (i < chars.Length - 4)
            {
                result += '#';
                i++;
            }
            for (int j = chars.Length - 4; j < chars.Length; j++)
            {
                result += chars[j];
            }
            return result;
        }
    }
}
