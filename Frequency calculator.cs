using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyCalculate
{
    class Program
    {
        static void calculateFreq(string str)
        {
            int i, cnt;
            Char ch;

            for (ch = (Char)65; ch <= 90; ch++)
            {
                cnt = 0;
                for (i = 0; i < str.Length; i++)
                {
                    if (ch == str[i] || (ch + 32) == str[i])
                    {
                        cnt++;
                    }
                }
                if (cnt > 0)
                {
                    Console.WriteLine(ch + "=" + cnt);
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        { 
            string str;
            Console.WriteLine("Enter any sentence");
            str = Console.ReadLine();
            calculateFreq(str);

        }
    }
}
