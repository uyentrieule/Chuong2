
namespace TrieuLeUyen_31231020264
{
    internal class Chuong_03
    {
        private static void Main(string[] args)
        {
            //Question_01();
            Question_02();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
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

        }
    }
        
}
