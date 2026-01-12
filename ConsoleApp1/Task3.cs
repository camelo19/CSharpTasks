namespace ConsoleApp1;
 public class Task3
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

        // Asking the User to enter a number to search
        Console.Write("Enter a number to search for: ");
        int user_input = int.Parse(Console.ReadLine());

        bool found = false;

        //  Using For Loop to find the entered number
        for (int i = 0; i < numbers.Length; i++)
        {

            // Breaking the loop if the entered number is found
            if (numbers[i] == user_input)
            {
                Console.WriteLine($"Number found at position {i + 1}.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Number not found in the list.");
        }
    }
    
}