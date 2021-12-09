using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Whrite 1:normal, 2:advaced or 3:exit");
                string nav = Console.ReadLine();


                if (nav == "3") { break; }

                if (nav == "1")
                {
                    Console.WriteLine("whrite first nuber");
                    double.TryParse(Console.ReadLine(), out double num1);

                    Console.WriteLine("whrite +*/-");
                    string mat = Console.ReadLine();

                    double.TryParse(Console.ReadLine(), out double num2);

                    Console.WriteLine(expetion(mat, num1, num2));

                }
                //I whanted to include this one eaven though its not the intended way.
                else if (nav == "2")
                {
                    Console.WriteLine("whrite the equation you whant to calculate example: 1+3*9=28, (8+9)/2=8.5 , 8+9/2=13.5 ");
                    string eqation = Console.ReadLine();

                    Console.WriteLine(oneRow(eqation));
                }
            }
        }
        static double expetion(string mat, double num1, double num2)
        {
            double equals;
            switch (mat)
            {
                case "+":
                    equals = adition(num1, num2);
                    break;
                case "-":
                    equals = subtraction(num1, num2);
                    break;
                case "*":
                    equals = multipli(num1, num2);
                    break;
                case "/":
                    equals = divide(num1, num2);
                    break;
                case "^":
                    equals = raisedby(num1, num2);
                    break;
                default:
                    equals = 0;
                    Console.WriteLine("Not valid input");
                    break;

            }
            return equals;
        }
        static double divide(double num1, double num2)
        {
            double div = 0;
            if (0 != num2)
            {
                div = num1 / num2;

            }
            else
            {
                Console.WriteLine("0 is nono");
            }
            return div;
        }
        static double multipli(double num1, double num2)
        {
            return num1 * num2;
        }
        static double adition(double num1, double num2)
        {
            return num1 + num2;
        }
        static double subtraction(double num1, double num2)
        {

            return num1 - num2;
        }
        static double raisedby(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }


        static double oneRow(string calc)
        {
            DataTable dt = new DataTable();
            double w = 0;
                
            try
            {
                var v = dt.Compute(calc, "");
                double.TryParse(v.ToString(), out w);

            }catch 
            {
                Console.WriteLine("Not valid input");
            }

            return w;

        }
    

        
    }
}
