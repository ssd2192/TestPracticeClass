using System;

namespace TestPracticeClass
{
    class Program
    {
        static string str;
        static void Main(string[] args)
        {
            
            Console.Write("Enter the Number: ");
            str = Console.ReadLine();

            if (IsPalindrom(str))
            {
                Console.WriteLine("Palindrom");
            }
            else
                Console.WriteLine("not palindrom");

            Console.ReadKey();
        }

        public static bool IsPalindrom(string str)
        {
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
