using System;

namespace SimpleTestApp
{
    public static class Math
    {
        public static int Addition(int X, int Y)
        {
            return X + Y;
        }

        public static int Subtraction(int X, int Y)
        {
            return X - Y;
        }

        public static int Multiplication(int X, int Y)
        {
            return X * Y;
        }

        public static int Division(int X, int Y)
        {
            return X / Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            string command;

            Console.WriteLine("Enter a Command (Add, Sub, Div, Mult)");

            while(run)
            {
                Console.Write("> ");
                command = Console.ReadLine();
                switch(command)
                {
                    case "a":
                    case "add":
                    case "Add":
                        try
                        {
                            int Input1, Input2 = -1;

                            Console.Write("1st Input: ");
                            Input1 = Int32.Parse(Console.ReadLine());

                            Console.Write("2nd Input: ");
                            Input2 = Int32.Parse(Console.ReadLine());

                            int ReturnValue = Math.Addition(Input1, Input2);
                            Console.WriteLine("Return: " + ReturnValue);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "s":
                    case "sub":
                    case "Sub":
                        try
                        {
                            int Input1, Input2 = -1;

                            Console.Write("1st Input: ");
                            Input1 = Int32.Parse(Console.ReadLine());

                            Console.Write("2nd Input: ");
                            Input2 = Int32.Parse(Console.ReadLine());

                            int ReturnValue = Math.Subtraction(Input1, Input2);
                            Console.WriteLine("Return: " + ReturnValue);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "m":
                    case "mult":
                    case "Mult":
                        try
                        {
                            int Input1, Input2 = -1;

                            Console.Write("1st Input: ");
                            Input1 = Int32.Parse(Console.ReadLine());

                            Console.Write("2nd Input: ");
                            Input2 = Int32.Parse(Console.ReadLine());

                            int ReturnValue = Math.Multiplication(Input1, Input2);
                            Console.WriteLine("Return: " + ReturnValue);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "d":
                    case "div":
                    case "Div":
                        try
                        {
                            int Input1, Input2 = -1;

                            Console.Write("1st Input: ");
                            Input1 = Int32.Parse(Console.ReadLine());

                            Console.Write("2nd Input: ");
                            Input2 = Int32.Parse(Console.ReadLine());

                            int ReturnValue = Math.Division(Input1, Input2);
                            Console.WriteLine("Return: " + ReturnValue);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case "q":
                    case "quit":
                    case "Quit":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Message: Invalid Command");
                        break;
                }
            }  
        }
    }
}
