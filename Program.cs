using System;

namespace CheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calc_check_digit("13361938"));
        }

        static int calc_check_digit(string BI)
        {
            int i=2;
            int sum=0;

            foreach(char c in BI)
            {
                sum += (c - '0') * i;
                i++;
            }

        return sum%11;
        }
    }
}
