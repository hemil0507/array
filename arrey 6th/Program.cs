using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrey_6th
{
    class Program
    {
        static void Main(string[] args)
        {
            Q7();
        }

        public static int[] GetInput(int N)
        {
            int[] MyArray = new int[N];
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine("Enter the value for the index "+i);
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            return MyArray;
        }

        public static void Print1DArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static void Q1()
        {
            Console.WriteLine("Enter the value for N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for K");
            int K = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = K;
            }
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

        }

        public static void Q2()
        {
            Console.WriteLine("Enter the value for N");
            int N = int.Parse(Console.ReadLine());
            Print1DArray(GetInput(N));
        }

        public static void Q3()
        {
            Console.WriteLine("Enter the value for N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for i");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for j");
            int j= int.Parse(Console.ReadLine());
            int[] MyArray=new int[N];
            Random r = new Random();
            for (int x = 0; x < MyArray.Length; x++)
            {
               
                MyArray[x] = r.Next(i, j);
            }
            for (int x = 0; x < MyArray.Length; x++)
            {
                Console.WriteLine(MyArray[x]);
            }

        }

        public static void Q4()
        {
            Console.WriteLine("Enter the value for m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for n");
            int n = int.Parse(Console.ReadLine());
            Random s = new Random();
            int N = s.Next(m, n);
            Console.WriteLine("Enter the value for i");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for j");
            int j = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            Random r = new Random();
            for (int x = 0; x < MyArray.Length; x++)
            {

                MyArray[x] = r.Next(i, j);
            }
            for (int x = 0; x < MyArray.Length; x++)
            {
                Console.WriteLine(MyArray[x]);
            }
            
        }

        public static void Q6()
        {
            Console.WriteLine("Enter the value for N");
            int N = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            int[] result = GetInput(MyArray.Length);
            for (int i = result.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine(result[i]);
            }
        }

        public static void Q7()
        {
            Console.WriteLine("Enter the value for N");
            int N = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            int[] result = GetInput(MyArray.Length);
            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(result[i]);
                }
            }
            
        }
        public static void Q8()
        {
            Console.WriteLine("enter the value for N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for K");
            int K = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            int[] result = GetInput(MyArray.Length);
            for (int i = K; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
        public static void Q9()
        {
            Console.WriteLine("enter the value for N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value K");
            int K = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            int[] result = GetInput(MyArray.Length);
            for (int i = K; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            
        }
        public static void Q10()
        {
            Console.WriteLine("enter the value for N");
            int N = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the value K");
            int K = int.Parse(Console.ReadLine());
            int[] MyArray = new int[N];
            int[] result = GetInput(MyArray.Length);
            if (K % 2 == 0)
            {
                for (int i = K; i < result.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(result[i]);
                    }
                }
            }
            else
            {
                for (int i = K; i < result.Length; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }

        }

    }
}




















