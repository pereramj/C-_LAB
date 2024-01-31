using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Name : ");
            String name = Console.ReadLine();
            String Grade = "";

            Console.Write("Enter Marks : ");
            int marks = int.Parse(Console.ReadLine());

            if (marks > 100)
            {
                Console.WriteLine("Wrong MArks !");
            }
            else if (marks >= 75)
            {
                Grade = "A";
            }
            else if (marks >= 65)
            {
                Grade = "B";
            }
            else if (marks >= 55)
            {
                Grade = "C";
            }
            else if (marks >= 45)
            {
                Grade = "D";
            }
            else
            {
                Grade = "Failed";
            }
            Console.WriteLine(name + " Your Grade is " + Grade);

            Console.ReadLine();
        }
           
    }
}
