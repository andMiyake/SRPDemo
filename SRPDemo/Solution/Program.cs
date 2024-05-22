namespace SRPDemo.Solution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();



            // Create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");

            StandardMessages.EndApplication();
        }
    }
}