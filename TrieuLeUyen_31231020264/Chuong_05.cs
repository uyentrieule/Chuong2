
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace TrieuLeUyen_31231020264
{
    internal class Chuong_05
    {
        private static void Main4(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03(); 
            Question_04();
            //Question_05();
            //Question_06();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Question_01()
        {
            Console.WriteLine("Enter the first number: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            float c = float.Parse(Console.ReadLine());
            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine($"{a} is the largest number");
                }
                else
                {
                    Console.WriteLine($"{c} is the largest number");
                }
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine($"{c} is the largest number");
                }
                else
                {
                    Console.WriteLine($"{b} is the largest number");
                }
            }
        }
        public static void Question_02()
        {
            static long Fact(int a)
            {
                long Fact = 1;
                for (int i = 1; i <= a; i++)
                    Fact *= i;
                Console.WriteLine($"The factorial of {a} is: {Fact} ");
                return Fact;
            }
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            Fact(a);
        }
        }
        public static void Question_03()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            check(a);
        }
        static bool check(int a)
        {
            for (int i = 2; i <= a; i++)
                if (a % i == 0)
                {
                   
                    return false;
                }
                else
                {
                   
                    return true;

                }
                return false;
        }
        static int Numsb4N (int a)
        {
            for (int i = 1; i <= a; i++)
                if (check(i) == true)
                    Console.WriteLine(i);
            return a;
        }
        public static void Question_04()
        {
            Console.Write("Enter a number: ");
            int a = int.Parse (Console.ReadLine());
            Numsb4N(a);
        }
        public static bool checkper(int a)
        {
             int sum = 0;
            for (int i = 1; i <= a / 2; i++)
                if (a % i == 0)
                    sum += i;
            if (sum == a) 
                return true;
            else return false;
        }
        public static int printper(int a)
        {
            for (int i = 1; i <= a; i++)
                if (checkper(i) == true)    
                Console.WriteLine($"{i} is a perfect number");
            return a;
        }
        public static void Question_05()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            checkper(a);
            printper(1000);
        }
    }
}

