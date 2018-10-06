using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersDemo
{
    class Program
    {
        public void Swap(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public void SwapByRef(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public void CircleFun(int radius, out double area, out double circum)
        {
            area = Math.PI * radius * radius;
            circum = 2 * Math.PI * radius;
        }

        public int Add(params int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int num1, num2;

            Console.Write("Enter Number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n****************************Pass By Value****************************");
            Console.WriteLine("Before Swapping :");
            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            p.Swap(num1, num2);

            Console.WriteLine("\nAfter Swapping :");
            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            Console.WriteLine("\n\n****************************Pass By Reference****************************");
            Console.WriteLine("Before Swapping :");
            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);
            
            p.SwapByRef(ref num1, ref num2);

            Console.WriteLine("\nAfter Swapping :");
            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            Console.WriteLine("\n\n****************************Pass By Output****************************");
            int radius;
            double area, circum;

            Console.Write("Enter Radius : ");
            radius = Convert.ToInt32(Console.ReadLine());

            p.CircleFun(radius, out area, out circum);

            Console.WriteLine("Area : " + area);
            Console.WriteLine("Circumference : " + circum);

            Console.WriteLine("\n\n****************************Pass By Output****************************");
            Console.WriteLine("Add(20, 30) : " + p.Add(20, 30));
            Console.WriteLine("Add(20,30,40) : " + p.Add(20, 30, 40));
            Console.WriteLine("Add(20,30,40,50,60,70) : " + p.Add(20, 30, 40, 50, 60, 70));
            Console.ReadKey();
        }
    }
}
