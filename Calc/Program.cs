Console.WriteLine("Calculator");

Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter operation (+, -, *, /): ");
string choice = Console.ReadLine();

Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

switch(choice)
{
    case "+":
        Console.WriteLine("Addition Result: " + (num1 + num2));
        break;
    case "-":
        Console.WriteLine("Subtraction Result: " + (num1 - num2));
        break;
    case "*":
        Console.WriteLine("Multiplication Result: " + (num1 * num2));
        break;
    case "/":
        Console.WriteLine("Division Result: " + (num1 / num2));
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}




