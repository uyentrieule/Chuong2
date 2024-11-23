
using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace TrieuLeUyen_31231020264
{
    internal class Chuong_04
    {
        private static void Main3(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            Question_10();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Question_01()
        {
            Console.WriteLine("Enter number a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a + b;
            float d = a - b;
            float e = a * b;
            float f = a / b;
            Console.WriteLine($"a + b = {c}, a - b = {d}, a * b = {e}, a / b = {f}");
        }
        public static void Question_02()
        {
            int y;
            for (y = -5; y <= 5; y++)
            {
                double x = Math.Pow(y, 2) - 2 * y + 1;
                Console.WriteLine($"y = {y}; x = ({y})^2 - 2*{y} +1 = {x}");
            }
        }
        public static void Question_03()
        {
            Console.WriteLine("Enter Km to input Km, Enter m to input miles");
            string donvi = Console.ReadLine();
            if (donvi == "Km")
            {
                Console.WriteLine("Enter hours: ");
                double h1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter minutes: ");
                double m1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter seconds: ");
                double s1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Km: ");
                double km = double.Parse(Console.ReadLine());
                double h2 = m1 / 60;
                double h3 = (s1 / 60) / 60;
                double h = h1 + h2 + h3;
                double speed1 = km / h;
                double km1 = km * 0.621371;
                double speed2 = km1 / h;
                Console.WriteLine($"Speed in Km/h is: {speed1} Km/h. Speed in miles/h is {speed2}");
            }   
            else
            {
                Console.WriteLine("Enter hours: ");
                double h1a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter minutes: ");
                double m1a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter seconds: ");
                double s1a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter miles: ");
                double m = double.Parse(Console.ReadLine());
                double h2a = m1a / 60;
                double h3a = (s1a / 60) / 60;
                double ha = h1a + h2a + h3a;
                double ma = m * 1.6093;
                double speed1a = ma / ha;
                double speed2a = m / ha;
                Console.WriteLine($"Speed in Km/h is: {speed1a} Km/h. Speed in miles/h is {speed2a}");
            }
        }
        public static void Question_04()
        {
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double Surface = 4 * Math.PI * Math.Pow(radius, 2);
            double Volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"The sphere's surface is {Surface}. The sphere's volume is {Volume}");
        }
        public static void Question_05()
        {
            Console.WriteLine("Enter a character: ");
            char character = char.Parse(Console.ReadLine());
            if (character == 'a' || character == 'u' || character == 'e' || character == 'i' || character == 'o'|| character == 'A' || character == 'U' || character == 'E' || character == 'I' || character == 'O')
            {
                Console.WriteLine($"{character} is a vowel");
            }
            else if (char.IsDigit(character))
            {
                Console.WriteLine($"{character} is a digit");
            }    
            else
            {
                Console.WriteLine($"{character} is a symbol");
            }
        }
        public static void Question_06()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even number");
            }
            else
            {
                Console.WriteLine($"{a} is an odd number");
            }
        }
        public static void Question_07()
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
        public static void Question_08()
        {
            Console.WriteLine("Enter the first coordinate: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate: ");
            int b = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                if (b > 0)
                {
                    Console.WriteLine($"The coordinate point ({a},{b}) lies in the First Quandrant");
                }
                else 
                {
                    if (b == 0)
                    {
                        Console.WriteLine($"The coordinate point ({a},{b}) lies on the Horizontal Axis");
                    }
                    else
                    {
                        Console.WriteLine($"The coordinate point ({a},{b}) lies in the Fourth Quandrant");
                    }
                }
            }
            else
            {
                if (a < 0)
                {
                    if (b > 0)
                    {
                        Console.WriteLine($"The coordinate point ({a},{b}) lies in the Second Quandrant");
                    }
                    else
                    {
                        Console.WriteLine($"The coordinate point ({a},{b}) lies in the Third Quandrant");
                    }
                }
                else 
                {
                    if (b == 0)
                    {
                        Console.WriteLine($"The coordinate point ({a},{b}) lies in the Origin");
                    }
                    else
                    {
                        Console.WriteLine($"The coordinate point ({a},{b}) lies on the Vertical Axis");
                    }
                }
            }
        }
        public static void Question_09()
        {
            Console.WriteLine("Enter the first side: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third side: ");
            float c = float.Parse(Console.ReadLine());
            if (a == b)
            {
                if (a == c)
                {
                    Console.WriteLine("This triangle is Equilateral");
                }
                else
                {
                    Console.WriteLine("This triangle is Isosceles");
                }
            }
            else
            {
                if (a == c)
                {
                    Console.WriteLine("This triangle is Isosceles");
                }
                else
                {
                    if (b == c)
                    {
                        Console.WriteLine("This triangle is Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("This triangle is Scalene");
                    }
                }
            }
        }
        public static void Question_10()
        {

        }
    }
}
