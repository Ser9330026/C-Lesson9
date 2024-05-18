using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] arr = new byte[3]; 
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            Int32[] arr2 = new Int32[3] { 1, 2, 3 };
            Int64[] arr3 = new Int64[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr2.Length; i++) 
            {
                Console.WriteLine(arr2[i]);
            }

            bool[] arr4 = new bool[3];
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            byte[,] array = new byte[3,3];

            for(int i = 0;i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
