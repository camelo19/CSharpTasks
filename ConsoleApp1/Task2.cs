namespace ConsoleApp1;
public class Task2
{
    static void Main(string[] args)
    {
// See https://aka.ms/new-console-template for more information
// Row 0: Even numbers
// Row 1: Odd numbers
        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 }
        };

        Console.WriteLine("The number matrix has been initialized.");

{
    // Digit 1
    int digit1 = numberMatrix[1][3];

    // Digit 2
    int digit2 = numberMatrix[0][0];
    
    // Digit 3
    int digit3 = numberMatrix[1][4]; 

    // the 3 digit key
    string key = string.Format("{0}{1}{2}", digit1, digit2, digit3);

    // Displaying them as password
    Console.WriteLine();
    Console.WriteLine("the 3 digits combinations from:");
    Console.WriteLine($"Digit 1: {digit1}");
    Console.WriteLine($"Digit 2: {digit2}");
    Console.WriteLine($"Digit 3: {digit3}");
    Console.WriteLine();
    Console.WriteLine($"and the password is: {key}");
}
    }

}