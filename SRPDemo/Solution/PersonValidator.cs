using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo.Solution
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            // Checks to be sure the first and last names are valid
            if (string.IsNullOrEmpty(person.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                StandardMessages.EndApplication();
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                StandardMessages.EndApplication();
                return false;
            }

        }
    }
}
