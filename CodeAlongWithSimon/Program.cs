using System;

namespace CodeAlongWithSimon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int number = 0;
            int userInput;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to my consoleApp");
            while (running)
            {
                Console.WriteLine("What do you want to do next? \nType 0 for for-loop\nType 1 for calculate age" +
                    "\nType 3 quit");

                number = GetNumber();
                switch(number)
                {
                    case 0:
                        Console.WriteLine("Write how may times for-loop will run");
                        userInput = GetNumber();
                        Console.WriteLine(userInput);
                        for (int i = 0; i <= userInput; i++)
                        {
                            Console.Write("\n#" + i);
                        }
                        break;
                    case 1:
                        Console.WriteLine("input birthyear to calculate age");
                        int birthyear = GetNumber();
                        Console.WriteLine (2021 - birthyear);
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.WriteLine("\ndo you want to quit type 1");
                        userInput = GetNumber();
                        if (userInput == 1)
                        {
                            running = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                     
                }
                

               
            }
        }
        //test input
        static int GetNumber()
        {
            int userInput = 0;
            bool succeeded = false;
            while (!succeeded)
            {
                succeeded = int.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
        static int GetNumber(string message)
        {
            return 0;
        }
        // Do not use "GoTo" =)
       /* static void Calculate(int num1 + int num2)
        {
            Console.WriteLine(num1 + num2);
        } */
    }
}
