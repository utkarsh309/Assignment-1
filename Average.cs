using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Average
    {
        static void Main(string[] args)
        {
            float[] arr = new float[5];
            Console.WriteLine("Enter the 5 Floating Value");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = float.Parse(Console.ReadLine());
            }
            float avg = 0;
            Console.WriteLine("Average is:- ");
            for (int i = 0; i < arr.Length; i++)
            {
                avg = avg + arr[i];
            }
            Console.WriteLine(avg / 5);
            Console.ReadLine();
        }
    }
}
