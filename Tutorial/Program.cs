using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                Console.WriteLine("Whrite 1:normal, 2:advaced, 3:array or 4:exit ");
                string nav = Console.ReadLine();
                

                if (nav == "4") { break; }
                switch (nav) 
                {
                    case "1":
                    Console.WriteLine("whrite first nuber");
                    double.TryParse(Console.ReadLine(), out double num1);

                    Console.WriteLine("whrite +*/-");
                    string mat = Console.ReadLine();

                    double.TryParse(Console.ReadLine(), out double num2);

                    Console.WriteLine(program.expetion(mat, num1, num2));

                        break;
                    case "2": 
                    Console.WriteLine("whrite the equation you whant to calculate example: 1+3*9=28, (8+9)/2=8.5 , 8+9/2=13.5 ");
                    string eqation = Console.ReadLine();

                    Console.WriteLine(program.oneRow(eqation));
                        break;
                    case "3":
                        Console.WriteLine("write +-");
                        string arnav=Console.ReadLine();
                        Console.WriteLine("write nubers and seperate them with /. use , for decimal nubers ");

                        string[] strArr=Console.ReadLine().Split('/');
                        double sum = 0;
                        if("-"==arnav)
                        {
                            sum = program.subtraction(strArr);
                        }
                        else if ("+" == arnav)
                        {
                          sum= program.adition(strArr);
                       
                        }
                        else
                        {
                            Console.WriteLine("not valid");
                        }
                        Console.WriteLine(sum);
                        break;
                    default: 
                        Console.WriteLine("not valid");
                        break;
                }

                
            }
        }
        public double expetion(string mat, double num1, double num2)
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
        public double adition(string[] numbers)
        {
            double[] sum = new double[numbers.Length];
            for (int i=0; i < numbers.Length; i++)
            {
                double.TryParse(numbers[i], out double num);
                sum[i] = num;
                
            }
            
            return sum.Sum();
        }
        public double subtraction(string[] numbers)
        {
            
            double.TryParse(numbers[0], out double sum);
            for (int i = 1; i < numbers.Length; i++)
            {
                double.TryParse(numbers[i], out double num);
                sum = sum - num;
                
            }

            return sum;
        }

        public double oneRow(string calc)
        {
            DataTable dt = new DataTable();
            double w = 0;
                
            try
            {
                var v = dt.Compute(calc, "");
                double.TryParse(v.ToString(), out w);
                

            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }

            return w;

        }
    

        
    }
}
