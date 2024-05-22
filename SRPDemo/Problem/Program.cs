

using SRPDemo.Problem;

Console.WriteLine("Welcome to my application");

// Ask for user information
Person person = new Person();

Console.Write("What is your first name? ");
person.FirstName = Console.ReadLine();

Console.Write("What is your last name? ");
person.LastName = Console.ReadLine();

// Checks to be sure the first and last names are valid
if (string.IsNullOrEmpty(person.FirstName))
{
    Console.WriteLine("You did not give us a valid first name!");
    Console.ReadLine();
    return;
}

if(string.IsNullOrEmpty(person.LastName))
{
    Console.WriteLine("You did not give us a valid last name!");
    Console.ReadLine();
    return;
}

// Create a username for the person
Console.WriteLine($"Your username is { person.FirstName.Substring(0, 1)}{person.LastName}");

Console.ReadLine();