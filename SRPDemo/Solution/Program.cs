using SRPDemo.Solution.Accounts;
using SRPDemo.Solution.Messages;
using SRPDemo.Solution.Persons;

namespace SRPDemo.Solution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if(isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}