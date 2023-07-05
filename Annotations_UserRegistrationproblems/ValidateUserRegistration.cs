using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations_UserRegistrationproblems
{
    internal class ValidateUserRegistration
    {
        public static void ValidateData()
        {
            UserRegistration user=new UserRegistration();
            Console.WriteLine("Enter First Name");
            string first=Console.ReadLine();
            user.First_Name = first;
            ValidationContext context=new ValidationContext(user,null,null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, results,true);
            if(!valid)
            {
                foreach(ValidationResult data in results)
                {
                    Console.WriteLine(data.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("First Name : "+user.First_Name+ " "+"is Valid");
            }
        }
    }
}
