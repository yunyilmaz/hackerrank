using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeronemultiple
{
    class Program
    {

        static void Main(string[] args)
        {
            int input = 0;
            byte test = 12;

            test = (byte)input;
            Console.WriteLine("Please Enter a Number");
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0 || input >= 100000)
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number. 0 < N < 100000");
            }


            for (int i = 1; i < 1000000; i++)
            {
                bool isZeroOne = CheckIfZeroOne(i * input);
                if (isZeroOne)
                {
                    Console.WriteLine("Smallest Zero One multiple of " + input + " is: ");
                    Console.WriteLine(i * input);
                    Console.WriteLine("Enter a key to exit");
                    Console.ReadLine();
                    break;
                }
            }

        }

        private static bool CheckIfZeroOne(int testnumber)
        {
            char[] digits = testnumber.ToString().Where(Char.IsDigit).ToArray();

            foreach (char digit in digits)
            {
                if (digit == '0' || digit == '1')
                    continue;
                else
                    return false;
            }

            return true;
        }

    }
}
