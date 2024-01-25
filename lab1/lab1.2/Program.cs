using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter a possitive number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0) 
            {
                for (int i = 1; i <= num; i++) 
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum is "+ sum +" ");
            }
            else 
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
