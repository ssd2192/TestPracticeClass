using System;

namespace TestPracticeClass
{
    class Program
    {
        static string str;
        static void Main(string[] args)
        {
            Palindrom p = new Palindrom();
            p.checkPalindrom();
            
            Console.ReadKey();
        }

       

    }
    class Palindrom
    {
        public void checkPalindrom()
        {
            Console.Write("Enter the String: ");
            string str = Console.ReadLine();

            if (IsPalindrom(str))
            {
                Console.WriteLine("Palindrom");
            }
            else
                Console.WriteLine("not palindrom");
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
