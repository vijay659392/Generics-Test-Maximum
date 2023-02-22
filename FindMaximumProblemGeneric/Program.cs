using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics");
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("============\nChoose Number :\n==============" +
                    "\nEnter 1:Finding Maximum Integer Number \n" +
                    "Enter 2:Finding Maximum Float Number\n" +
                    "Enter 3:Finding Maximum String Value");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    //case 1:
                    //    MaximumNumber.FindingMaximum(9, 5, 1);
                    //    break;
                    //case 2:
                    //    MaximumNumber.FindingFloatMaximum(1.2, 3.2, 4.3);
                    //    break;
                    //case 3:
                    //    MaximumNumber.FindingStringMaximum("Hyerabad,Pune,Banglor");
                    //    break;

                }
            }
        }
    }
}
