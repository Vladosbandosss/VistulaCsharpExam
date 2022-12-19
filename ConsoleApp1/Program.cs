using System;
using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
using System.Text;
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
          //SolveProblem1();
           
          //SolveProblem2();
           
          //SolveProblem3();
           
          //SolveProblem4();
           
          //SolveProblem5();
          
        }
        public static void SolveProblem1()
        {
            Console.WriteLine(-1+4*6);
            Console.WriteLine((35+5)%7);
            Console.WriteLine(14+-4*6/11);
            Console.WriteLine(2+15/6*1-7%2);
        }

        public static void SolveProblem2()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void SolveProblem3()
        {
            double volume,area;
            
            float fourDevidedByThree = 4f / 3f;

            Console.WriteLine("Please enter radius");
            double radius = Convert.ToDouble(Console.ReadLine());

            volume = fourDevidedByThree * Math.PI * Math.Pow(radius, 3);
            area = 4 * Math.PI * Math.Pow(radius, 2);
            
            Console.WriteLine(Math.Round(volume,5));
            Console.WriteLine(Math.Round(area,5));
        }

        public static void SolveProblem4()
        {
            Console.WriteLine("Please enter mark");
            double mark = Convert.ToDouble(Console.ReadLine());

            string resultMark="";

            switch (mark)
            {
                case 5 :
                    resultMark = "Excellent";
                    break;
                
                case 4.5:
                    resultMark = "Very Good";
                    break;
                case 3:
                    resultMark = "Good";
                    break;
                
                case 2:
                    resultMark = "Fail";
                    break;
                
                default:
                    Console.WriteLine("Error,please repeat");
                    break;
            }
            
            Console.WriteLine($"Your grade is {resultMark}");
        }

        public static void SolveProblem5()
        {
            Console.WriteLine("Enter numbers of rows");

            int rows = Convert.ToInt32(Console.ReadLine());
            
            int symbolToWrite = 1;

            for (int i = 1; i <=rows; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(symbolToWrite +" ");
                    symbolToWrite++;
                }
                Console.WriteLine();
            }
        }
    }
}





