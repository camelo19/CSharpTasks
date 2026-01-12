namespace ConsoleApp1;
public class Task5
{
    // Force numeric input within range 0–100
    static int GetMarks(string subject)
    {
        int marks;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write($"Enter {subject} Marks (Out Of 100): ");
            try
            {
                marks = int.Parse(Console.ReadLine());

                if (marks >= 0 && marks <= 100)
                    return marks;
                else
                    Console.WriteLine("Invalid Input. Marks must be between 0 and 100.");
            }
            catch
            {
                Console.WriteLine("Invalid Input. Please enter numbers only.");
            }
        }
        return 0;
    }

    static void Main()
    {
        Console.Write("Enter Total Students: ");
        int totalStudents;

        // Stack variable
        while (!int.TryParse(Console.ReadLine(), out totalStudents) || totalStudents <= 0)
        {
            Console.WriteLine("Invalid Input. Enter a positive number.");
        }

        // HEAP: Jagged array to store student data
        // [student][0] = English, [1] = Math, [2] = Computer, [3] = Total
        int[][] marks = new int[totalStudents][];
        string[] names = new string[totalStudents];

        int i = 0; // register-style loop counter

        // WHILE LOOP for input
        while (i < totalStudents)
        {
            marks[i] = new int[4]; // heap allocation

            Console.Write($"Enter Student Name: ");
            names[i] = Console.ReadLine();

            marks[i][0] = GetMarks("English");
            marks[i][1] = GetMarks("Math");
            marks[i][2] = GetMarks("Computer");

            // Stack calculation
            marks[i][3] = marks[i][0] + marks[i][1] + marks[i][2];

            Console.WriteLine("************************************");
            i++;
        }

        // Sorting students by total marks (Descending)
        int x = 0;
        while (x < totalStudents - 1)
        {
            int y = x + 1;
            while (y < totalStudents)
            {
                if (marks[x][3] < marks[y][3])
                {
                    // Swap totals & grades (heap)
                    int[] tempMarks = marks[x];
                    marks[x] = marks[y];
                    marks[y] = tempMarks;

                    // Swap names
                    string tempName = names[x];
                    names[x] = names[y];
                    names[y] = tempName;
                }
                y++;
            }
            x++;
        }

        // REPORT CARD OUTPUT
        Console.WriteLine("************* Report Card *************");

        int position = 1;
        int index = 0;

        while (index < totalStudents)
        {
            Console.WriteLine($"Student Name: {names[index]}, Position: {position}, Total:");
            Console.WriteLine($"{marks[index][3]}/300");
            Console.WriteLine("************************************");
            position++;
            index++;
        }
    }
}