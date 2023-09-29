

using AbstractCalculator;
Calculator calculator = new Calculator();
bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    Header();
    Console.WriteLine("Type the first number: ");
    Console.Write("First number: ");
    string input1 = Console.ReadLine();

    Console.WriteLine("Type the second number: ");
    Console.Write("Second number: ");
    string input2 = Console.ReadLine();

    Console.WriteLine("Which type of calculation do you wish to do?\n type 'add', 'subtract', 'divide' or 'multiply'");
    string op = Console.ReadLine();
    calculator.Calculate(input1, input2, op);

    Console.WriteLine("Do you want to make a new calculation? type 'y' for yes and 'n' for no.");
    string answer = Console.ReadLine();

    if (answer.Equals("n") || answer.Equals("N"))
    {
        Console.Clear();
        Finished();
        isRunning = false;
    }

}


void Header()
{
    Console.WriteLine("  .--.      .-'.      .--.      .--.      .--.      .--.      .`-.      .--.\r\n:::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\\r\n'      `--'      `.-'      `--'      `--'      `--'      `-.'      `--'      `");
    Console.WriteLine("       SUPER COOL ABSTRACT CALCULATOR          ");
    Console.WriteLine("  .--.      .-'.      .--.      .--.      .--.      .--.      .`-.      .--.\r\n:::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\\r\n'      `--'      `.-'      `--'      `--'      `--'      `-.'      `--'      `");
}

void Finished()
{
    Console.WriteLine(" _____ ___ _   _ ___ ____  _   _ _____ ____   \r\n|  ___|_ _| \\ | |_ _/ ___|| | | | ____|  _ \\  \r\n| |_   | ||  \\| || |\\___ \\| |_| |  _| | | | | \r\n|  _|  | || |\\  || | ___) |  _  | |___| |_| | \r\n|_|   |___|_| \\_|___|____/|_| |_|_____|____/  ");
}