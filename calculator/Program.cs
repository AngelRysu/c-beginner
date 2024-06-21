using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("-------Hello User-------");
      Console.WriteLine("1)Addition\n2)Subtraction\n3)Multiplication\n4)Division\nAny other key to exit");
      Console.Write("Select your operation: ");
      int chose = Convert.ToInt32(Console.ReadLine());
      switch(chose){
        case 1:
            Console.Clear(); 
            Console.WriteLine("You Chose Addition, please entrer 2 numbers");
            Console.Write("number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");
            break;
        case 2:
            Console.Clear(); 
            Console.WriteLine("You Chose Subtraction, please entrer 2 numbers");
            break;
        case 3:
            Console.Clear(); 
            Console.WriteLine("You Chose Multiplication, please entrer 2 numbers");
            break;
        case 4:
            Console.Clear(); 
            Console.WriteLine("You Chose Division, please entrer 2 numbers");
            break;
        default:
            Console.WriteLine("Thanks for using the program");
            break;
      }
    }
  }
}