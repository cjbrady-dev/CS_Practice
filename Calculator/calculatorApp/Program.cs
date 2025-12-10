using System;
using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;

namespace myCalculatorApp
{
    public class Program
    {
        public int total = 0;
        public static void Main(string[] args) 
        {
            Program calculator = new Program();
            Console.WriteLine("Welcome to my calculator!");
            Console.WriteLine("Please enter your operation.");
            int inticalNum = int.Parse(Console.ReadLine());
            calculator.total += inticalNum;
            char numVal = Console.ReadLine()[0];
            calculator.Calculate(numVal);
            while(numVal != 'x')
            {
                Console.WriteLine("Please enter your operation.");
                numVal = Console.ReadLine()[0];
                calculator.Calculate(numVal);
            }
            Console.WriteLine($"{calculator.total}");
 
        }

        public int Calculate(char sym)
            {
            switch (sym)
            {
                case '+':
                    
                    Console.WriteLine("Enter a number");
                    int numVal = int.Parse(Console.ReadLine());
                    total += numVal;
                    break;

                case '-':
                    Console.WriteLine("Enter a number");
                    numVal = int.Parse(Console.ReadLine());
                    total -= numVal;
                    
                    break;

                case '*':
                    Console.WriteLine("Enter a number");
                    numVal = int.Parse(Console.ReadLine());
                    total *= numVal;
                    break;

                case '/':
                    Console.WriteLine("Enter a number");
                    numVal = int.Parse(Console.ReadLine());
                    total /= numVal;
                    break;
                    
                case 'x':
                    Console.WriteLine($"Your final total is: {total}");
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            return total;
        }
    }
    
}