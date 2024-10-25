using System.Diagnostics.Metrics;

internal class Chuong_02
{
    private static void Main1(string[] args)
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
        //Question_10();
        Console.WriteLine("Press any key to stop");
        Console.ReadKey();
    }
    /// </summary>
    /// Add / Sum Two Numbers
    /// </summary>
    public static void Question_01()
    {
        Console.WriteLine("Enter number a =");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b =");
        int b = int.Parse(Console.ReadLine());
        int Sum = a + b;
        Console.WriteLine($"{a} + {b} = {Sum}");
    }
    /// <summary>
    /// Swap Values of Two Variables
    /// </summary>
    public static void Question_02()
    {
        Console.WriteLine("Enter number a =");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b =");
        int b = int.Parse(Console.ReadLine());
        int m = a;
        a = b; b = m;
        Console.WriteLine($" New a is {a}, New b is {b}");
    }
    /// <summary>
    /// Multiply two Floating Point Numbers
    /// </summary>
    public static void Question_03()
    {
        Console.WriteLine("Enter number a");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b");
        float b = float.Parse(Console.ReadLine());
        float Multiply = a * b;
        Console.WriteLine($"{a} * {b} = {Multiply}");
    }
    /// <summary>
    /// Convert feet to meter
    /// </summary>
    public static void Question_04()
    {
        Console.Write("Enter feet: ");
        double a = double.Parse(Console.ReadLine());
        double doidonvi = 0.3048;
        double meter = a * doidonvi;
        Console.WriteLine($"Gia tri quy doi la {meter}");
    }
    /// <summary>
    /// Convert Celsius to Fahrenheit and vice versa
    /// </summary>
    public static void Question_05()
    {
        Console.WriteLine("Enter C to change from Celsius to Farenheit, Emter F to change from Farenheit to Celsius");
        string donvi = Console.ReadLine();
        if (donvi == "C")
        {
            Console.WriteLine("Enter Celsius degree: ");
            double degreeCelsius = double.Parse(Console.ReadLine());
            double degreeFarenheit = degreeCelsius * (9 / 5) + 32;
            Console.WriteLine($"Degree Farenheit is: {degreeFarenheit}");
        }
        else
        {
            Console.WriteLine("Enter Farenheit degree: ");
            double degreeFarenheit = double.Parse(Console.ReadLine());
            double degreeCelsius = (degreeFarenheit - 32) * (5 / 9);
            Console.WriteLine($"Degree Celsius is: ");
        }
    }
    /// <summary>
    /// Find the Size of data types
    /// </summary>
    public static void Question_06()
    {
        int a = sizeof(int);
            Console.WriteLine($"Size of data type int is: {a}");
    }
    /// <summary>
    /// Print ASCII Value
    /// </summary>
    public static void Question_07()
    {
        Console.WriteLine("Enter a character: ");
        Char inputchar = char.Parse(Console.ReadLine());
        int ascii = (int)inputchar;
        Console.WriteLine($"The ASCII Value of {inputchar} is: {ascii} ");
    }
    /// <summary>
    /// Calculate Area of Circle
    /// </summary>
    public static void Question_08()
    {
        Console.WriteLine("Enter radius of the circle: ");
        double Circle_Radius = double.Parse(Console.ReadLine());
        const double PI = Math.PI;
        double Circle_Area = Circle_Radius * Circle_Radius * Math.PI;
        Console.WriteLine($"The Area of the circle is: {Circle_Area}");
    }
    /// <summary>
    /// Calculate Area of Square
    /// </summary>
    public static void Question_09()
    {
        Console.WriteLine("Enter wide a: ");
        double a = double.Parse(Console.ReadLine());
        double b = a * a;
        Console.WriteLine($"The Area of the square is: {b}");
    }
    public static void Question_10()
    {
        Console.WriteLine( "Enter the number of days: ");
        int Days = int.Parse(Console.ReadLine());
        int Years = Days / 365;
        int Days_week = Days - Years * 365;
        int Weeks = Days_week / 7;
        int D = Days_week % 7;
        Console.WriteLine($"{Days} days equal to {Years} years, {Weeks} weeks and {D} days");
    }
}