using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class EvenAndOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the Array:- ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Values of Array:- ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int even = 0;
            int odd = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0){ even++; }
                else { odd++; };
            }
            Console.WriteLine("Total Male is:- " + even);
            Console.WriteLine("Total Female is:- "+odd);
        }
    }
}