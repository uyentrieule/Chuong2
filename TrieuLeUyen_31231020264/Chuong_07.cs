using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrieuLeUyen_31231020264
{
    internal class Chuong_07
    {
        private static void Main10(string[] args) 
        {
            //Question_01();
            Question_02();
        }
        public static void Question_01()
        {
            Console.WriteLine("Enter row: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter column: ");
            int column = int.Parse(Console.ReadLine());
            int[,] a = new int [row, column];
            Import(a);
            Console.WriteLine("Print row/column: ");
            int RowCol = int.Parse(Console.ReadLine());
            Print(a,RowCol);
            Console.WriteLine("Press any key to print Primary Diagnol");
            Primary(a);
            Console.WriteLine("Press any key to print SecodaryS Diagnol");
            Secondary(a);
        }
        static void Import (int[,] a)
        {
            Random random = new Random();
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0;j < a.GetLength(1); j++)
                {
                    a[i,j] = random.Next(100);
                    Console.Write(a[i, j] +" ");
                }
                Console.WriteLine();
            }    
        }
        static void Print (int[,] a, int RowCol)
        {
            if (RowCol < 0 || RowCol > a.GetLength(0) -1)
            {
                Console.WriteLine("Please enter the row/column in matrix");
                return;
            }
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.WriteLine(a[RowCol,j] + " ");
            }
        }
        static void MaxVal (int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {

            }
        }
        static void Primary (int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j =0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                        Console.WriteLine(a[i,j] +" ");
                }
            }
                
        }
        static void Secondary (int[,] a)
        {
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (i + j == a.GetLength(0) - 1)
                        Console.WriteLine(a[i, j] + " ");
                }
            }
        }
        public static void Question_02 ()
        {
            Console.Write("Nhap so cot ban muon: ");
            int a = int.Parse (Console.ReadLine());
            int[] array = new int[a];
            Exportnrandom(array);
            Test(array);
            Console.Write("Nhap so ban muon bo: ");
            int b = int.Parse (Console.ReadLine());
            array = remove(array, b);
            Export(array);
            Max(array);
            Min(array);
            Reverse(array);
            Export(array);
        }
        /// <summary>
        /// create a array 
        /// </summary>
        /// <param name="a"></param>
        static void Export(int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
        static void Exportnrandom(int[]a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// test if an array contains a specific value & find the index of an array element
        /// </summary>
        /// <param name="a"></param>
        static void Test (int[]a)
        {
            Console.Write("Nhap so ban can tim: ");
            int b = int.Parse (Console.ReadLine());
            int check = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    Console.WriteLine($"So ban tim o vi tri: {i+1}");
                    check = 1;
                }
            }
            if (check == -1)
            {
                Console.WriteLine("So ban tim khong o trong mang");
            }
        }
        static int[] remove(int[] a, int socanbo)
        {
            int count = 0, k = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] == socanbo)
                    count++;
            }    
            int[] b = new int[a.Length - count];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == socanbo)
                {
                    k++;
                    continue;
                }
                else
                {
                    b[i - k] = a[i];
                }
            }    
            return b;
        }
        /// <summary>
        /// find the maximum and minimum value of an array
        /// </summary>
        /// <param name="a"></param>
        static void Max(int[]a)
        {
            int max = a[0];
            for (int i = 0;i<a.Length;i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"So lon nhat là: {max}");
        }
        static void Min(int[]a)
        {
            int min = a[0];
            for (int i = 0; i<a.Length;i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine($"So nho nhat la: {min}");
        }
        /// <summary>
        /// reverse an array of integer values.
        /// </summary>
        /// <param name="a"></param>
        static void Reverse (int[] a)
        {
            for (int i = 0; i<a.Length/2; i++)
            {
                int b = a[i];
                a[i] = a[a.Length-i-1];
                a[a.Length - i - 1] = b;
            }
        }
        static void Duplicate(int[] a)
        {

        }
    }
}
