
using System.Net.Http.Headers;

namespace TrieuLeUyen_31231020264
{
    internal class Chuong_04
    {
        private static void Main(string[] args)
        {
            //Question_02();
            //Question_03();
            Question_05();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
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
    }
}
