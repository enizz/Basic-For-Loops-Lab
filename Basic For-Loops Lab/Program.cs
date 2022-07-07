 do
    {
        Console.WriteLine("Enter a number..");

        int x = int.Parse(Console.ReadLine());
        int y = 0;

        for (int i = 1; i <= x; i++)
        {
            y += i;
        }

        Console.WriteLine("The sum of all the numbers from 1 to " + x + " is: " + y);
        Console.WriteLine("Would you like to continue? Y/N");
    }
while (Console.ReadKey().Key == ConsoleKey.Y);
