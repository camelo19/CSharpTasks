namespace ConsoleApp1;
public class Task4
{
    
    static void Main(string[] args)
    {
        bool Display_Instructions = true;

        while (Display_Instructions != false)
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

  // Method that forces numeric input only
    static int Get_User_Input()
    {
        int number;
        bool Valid = false;

        while (!Valid)
        {
            try
            {
                number = int.Parse(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.Write("Invalid Input. Please only enter numbers: ");
            }
        }
        return 0;
    }

            int choose_operation = Get_User_Input();

            Console.WriteLine("");
            Console.Write("Enter Value 1: ");
            int value1 = Get_User_Input();

            Console.Write("Enter Value 2: ");
            int value2 = Get_User_Input();

            switch (choose_operation)
            {
                
      //Aritmetic Operator for Addition
                case 1:
    static int Add(int a, int b)
    {
        return a + b;
    }
                    Console.WriteLine($"{value1} + {value2} = {Add(value1, value2)}");
                    break;
                    
     //Aritmetic Operator for Subtraction
                case 2:
    static int Subtract(int a, int b)
    {
        return a - b;
    }
                    Console.WriteLine($"{value1} - {value2} = {Subtract(value1, value2)}");
                    break;
                    
     //Aritmetic Operator for Multiplication
                case 3:
    static int Multiply(int a, int b)
    {
        return a * b;
    }
                    Console.WriteLine($"{value1} * {value2} = {Multiply(value1, value2)}");
                    break;

            //Aritmetic Operator for Division
                case 4:
    static int Divide(int a, int b)
    {
        return a / b;
    }
                    if (value2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"{value1} / {value2} = {Divide(value1, value2)}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Y/N validation loop
            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine("");
                Console.Write("Do you want to continue again (Y/N)? ");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "Y")
                {
                    validChoice = true;
                }
                else if (choice == "N")
                {
                    validChoice = true;
                    Display_Instructions = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write("Invalid Input, please only enter Y or N.");
                }
            }
        }
    }
}