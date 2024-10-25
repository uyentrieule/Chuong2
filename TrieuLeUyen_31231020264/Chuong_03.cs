
namespace TrieuLeUyen_31231020264
{
    internal class Chuong_03
    {
        private static void Main2(string[] args)
        {
            //Question_01();
            //Question_02();
            Question_03();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        /// <summary>
        /// Convert from degrees Celsius to Kelvin and Fahrenheit
        /// <summary>
        public static void Question_01()
        {
            Console.WriteLine("Enter Celsius degree: ");
            int Celsius = int.Parse(Console.ReadLine());
            int Kelvin = Celsius + 273;
            int Farenheit = Celsius * 18 / 10 + 32;
            Console.WriteLine($"{Celsius} degrees equal to {Kelvin} Kelvin degrees and {Farenheit} Farenheit degrees");
        }
        public static void Question_02()
        {
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double Surface = 4 * Math.PI * Math.Pow(radius,2);
            double Volume = 4 / 3 * Math.PI * Math.Pow(radius,3);
            Console.WriteLine($"The sphere's surface is {Surface}. The sphere's volume is {Volume}");

        }
        /// <summary>
        /// Calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user
        /// </summary>
        public static void Question_03()
        {
            Console.WriteLine("Enter number a: ");
             int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;
            Console.WriteLine($"a + b = {c}. a * b = {d}. a * b = {e}. a / b = {f}. The rest of the division is {g}");
        }
    }
        
}
