using SRPDemo.Solution.Messages;

namespace SRPDemo.Solution.Persons
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            // Checks to be sure the first and last names are valid
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                //StandardMessages.EndApplication(); -----> Passing the responsability to the Main,
                //now PersonValidator doesn`t need to know where we are at the application
                return false;
            }

            return true;
        }
    }
}
