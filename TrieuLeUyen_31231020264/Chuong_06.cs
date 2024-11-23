
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace TrieuLeUyen_31231020264
{
    internal class Chuong_06
    {
        private static void Main5(string[] args)
        {
            //Question_01();
            //Question_02();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Question_01()
        {
            Console.WriteLine("Enter the number of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            import(a);
            //print(a);
            //add2(a, 2);
            //print(a);
            //sum(a);
            //avr(a);
        }
        static void import(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
            }
            static void print(int[] a)
            {
                foreach (int item in a)
                {
                    Console.WriteLine(item);
                }
            }
            static void add2(int[] a, int value)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] += value;
                }
            }
            static void sum(int[] a)
            {
                int s = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    s += a[i];
                }
            }
            static void avr(int[] a)
            {
                long trungbinh;
                for (int i = 0; i < a.Length; i++)
                {
                    //trungbinh = sum / n;
                }
            }
            //static void Question_02()
            {
                Console.WriteLine("Enter the number of array: ");
                int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];
            }
            static void taomang(int[] a)
            {
                Random random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(100);
                }
            }
        }
    }
}
