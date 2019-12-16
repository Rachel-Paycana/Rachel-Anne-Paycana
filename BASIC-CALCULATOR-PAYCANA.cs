using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rachel
{
    class Program
    {
        static void Main(string[] args)

         
        {
         
            Console.WriteLine("RACHEL's BASIC CALCULATOR   \n\n");
            Console.WriteLine("Enter operation to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            float action = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter your 1st number");
            float number1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter your 2nd number");
            float number2 = Convert.ToSingle(Console.ReadLine());
            float answer = 0;
            switch (action)
            {
                case 1:
                    {
                        answer = Addition(number1, number2);
                        Console.WriteLine("The sum is {0}", answer);
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        answer = Subtraction(number1, number2);
                        Console.WriteLine("The difference is {0}", answer);
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        answer = Multiplication(number1, number2);
                        Console.WriteLine("The product is {0}", answer);
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        answer = Division(number1, number2);
                        Console.WriteLine("The quotient is {0}", answer);
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("INVALID OPERATION!");
                    break;
            }

       
        }
        //Addition  
        public static float Addition(float number1, float number2)
        {
            float answer = number1 + number2;
            return answer;
        }
        //Substraction  
        public static float Subtraction(float number1, float number2)
        {
            float answer = number1 + number2;
            return answer;
        }
        //Multiplication  
        public static float Multiplication(float number1, float number2)
        {
            float answer = number1 + number2;
            return answer;
        }
        //Division  
        public static float Division(float number1, float number2)
        {
            float answer = number1 + number2;
            return answer;
        }
    }
}
