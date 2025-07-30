using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class SumOfArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the Values of Array");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("array is:-" );
            for(int i = 0; i < 5; i++)
            {
                Console.Write(arr[i]+" ");
            }
            int sum = 0;
            for(int i=0; i < arr.Length; i++) { sum += arr[i]; }
            Console.WriteLine("Sum of the Arrays is " + sum);
        }

    }
}
