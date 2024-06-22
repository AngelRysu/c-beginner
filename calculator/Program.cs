using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("-------Hello User-------");
      bool closer = true;

      do
      {
        Console.WriteLine("1)Addition\n2)Subtraction\n3)Multiplication\n4)Division\nAny other key to exit");
        Console.Write("Select your operation: ");
        string? chose = Console.ReadLine();
        double number1;
        double number2;
        double result;
        if (chose == null)
          {
              Console.WriteLine("Invalid selection. Exiting the program.");
              return;
          }
        switch(chose){
          case "1":
                  Console.Clear();
                  Console.WriteLine("You Chose Addition, please enter 2 numbers");
                  Console.Write("number 1: ");
                  if (!double.TryParse(Console.ReadLine(), out number1))
                  {
                      Console.WriteLine("Invalid input for number 1. Exiting the program.");
                      return;
                  }
                  Console.Write("number 2: ");
                  if (!double.TryParse(Console.ReadLine(), out number2))
                  {
                      Console.WriteLine("Invalid input for number 2. Exiting the program.");
                      return;
                  }
                  result = number1 + number2;
                  Console.WriteLine($"{number1} + {number2} = {result}");
                  break;

              case "2":
                  Console.Clear();
                  Console.WriteLine("You Chose Subtraction, please enter 2 numbers");
                  Console.Write("number 1: ");
                  if (!double.TryParse(Console.ReadLine(), out number1))
                  {
                      Console.WriteLine("Invalid input for number 1. Exiting the program.");
                      return;
                  }
                  Console.Write("number 2: ");
                  if (!double.TryParse(Console.ReadLine(), out number2))
                  {
                      Console.WriteLine("Invalid input for number 2. Exiting the program.");
                      return;
                  }
                  result = number1 - number2;
                  Console.WriteLine($"{number1} - {number2} = {result}");
                  break;

              case "3":
                  Console.Clear();
                  Console.WriteLine("You Chose Multiplication, please enter 2 numbers");
                  Console.Write("number 1: ");
                  if (!double.TryParse(Console.ReadLine(), out number1))
                  {
                      Console.WriteLine("Invalid input for number 1. Exiting the program.");
                      return;
                  }
                  Console.Write("number 2: ");
                  if (!double.TryParse(Console.ReadLine(), out number2))
                  {
                      Console.WriteLine("Invalid input for number 2. Exiting the program.");
                      return;
                  }
                  result = number1 * number2;
                  Console.WriteLine($"{number1} * {number2} = {result}");
                  break;

              case "4":
                  Console.Clear();
                  Console.WriteLine("You Chose Division, please enter 2 numbers");
                  Console.Write("number 1: ");
                  if (!double.TryParse(Console.ReadLine(), out number1))
                  {
                      Console.WriteLine("Invalid input for number 1. Exiting the program.");
                      return;
                  }
                  Console.Write("number 2: ");
                  if (!double.TryParse(Console.ReadLine(), out number2))
                  {
                      Console.WriteLine("Invalid input for number 2. Exiting the program.");
                      return;
                  }
                  if (number2 == 0)
                  {
                      Console.WriteLine("Division by zero is not allowed. Exiting the program.");
                      return;
                  }
                  result = number1 / number2;
                  Console.WriteLine($"{number1} / {number2} = {result}");
                  break;

              default:
                  Console.WriteLine("Thanks for using the program.");
                  closer = false;
                  break;
        }
      }while(closer);
    } 
  }
}