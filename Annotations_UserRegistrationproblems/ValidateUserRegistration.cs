using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations_UserRegistrationproblems
{
    public class ValidateUserRegistration
    {
        UserRegistration user = new UserRegistration();
        public void ValidateFirstName()
        {
            Console.WriteLine("Enter First Name");
            string first = Console.ReadLine();
            user.First_Name = first;
            ValidationContext context = new ValidationContext(user, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult data in results)
                {
                    Console.WriteLine(data.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("First Name : " + user.First_Name + " " + "is Valid");
            }
        }
        public void ValidateLastName()
        {
            ValidateLastName lastName= new ValidateLastName();
            Console.WriteLine("Enter Last Name");
            string last = Console.ReadLine();
            lastName.Last_Name = last;
            ValidationContext context = new ValidationContext(lastName, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(lastName, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult data in results)
                {
                    Console.WriteLine(data.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Last Name : " + lastName.Last_Name + " " + "is Valid");
            }
        }
        public void ValidateEmail()
        {
            ValidateEmail email= new ValidateEmail();
            Console.WriteLine("Enter Email Address");
            string mail= Console.ReadLine();
            email.Email = mail;
            ValidationContext context=new ValidationContext(email, null, null);
            List<ValidationResult> results= new List<ValidationResult>();
            bool valid=Validator.TryValidateObject(email, context,results, true);
            if(!valid)
            {
                foreach(ValidationResult data in results)
                {
                    Console.WriteLine(data.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Email : " + email.Email + " " + "is Valid");
            }
        }
        public void ValidatePhone()
        {
            ValidatePhoneNumber number= new ValidatePhoneNumber();
            Console.WriteLine("Enter 10 Digits Phone Number");
            string mobile= Console.ReadLine();
            number.Phone = mobile;
            ValidationContext context= new ValidationContext(number, null, null);
            List<ValidationResult > results= new List<ValidationResult>();
            bool valid=Validator.TryValidateObject(number, context, results, true);
            if(!valid)
            {
                foreach(ValidationResult data in results)
                {
                    Console.WriteLine(data.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Phone Number : " + number.Phone + " " + "is Valid");
            }
        }
        public void ValidatePasswordRule1()
        {
            ValidatePasswordRule1 rule1 = new ValidatePasswordRule1();
            Console.WriteLine("Enter Password ");
            string pass = Console.ReadLine();
            rule1.Password = pass;
            ValidationContext context = new ValidationContext(rule1, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(rule1, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult data in results)
                {
                    Console.WriteLine(data.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Password Rule-1 : " + rule1.Password + " " + "is Valid");
            }
        }
        public void ValidatePasswordRule2()
        {
            ValidatePasswordRule2 rule2 = new ValidatePasswordRule2();
            Console.WriteLine("Enter Password ");
            string pass = Console.ReadLine();
            rule2.Password = pass;
            ValidationContext context = new ValidationContext(rule2, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(rule2, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult data in results)
                {
                    Console.WriteLine(data.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Password Rule-1 : " + rule2.Password + " " + "is Valid");
            }
        }
    }
}
