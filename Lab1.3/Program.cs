
bool validNum = false;
bool exitFlag = false;
do
{
    Console.WriteLine("Hello! Please enter an integer.");
    double input = double.Parse(Console.ReadLine());
    if (input <= 0)
    {
        validNum = false;

    }
    else
    {
        validNum = true;
        Console.WriteLine("Numbers\tSquared\tCubed");
        Console.WriteLine("=====================");
        for (double i = 1; i <= input; i++)
        {
            double squared = Math.Pow(i, 2);
            double cubed = Math.Pow(i, 3);
            Console.WriteLine($"{i}\t{squared}\t{cubed}");
        }
        Console.WriteLine("Would you like to go again? Please enter yes or no.");
        string goAgain = Console.ReadLine();
        if (goAgain != "yes")
        {
            exitFlag = true;

        }
        else
        {
            exitFlag = false;
            validNum = false;

        }

    }

    
} while (!validNum && !exitFlag);
