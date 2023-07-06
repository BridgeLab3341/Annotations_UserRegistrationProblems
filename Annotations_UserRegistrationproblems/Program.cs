﻿using Annotations_UserRegistrationproblems;

namespace Annotations_UserRegistrationProblems
{
    class Program
    {
        public static void Main(string[] args)
        {

            ValidateUserRegistration valid=new ValidateUserRegistration();
            bool flag = true;
            while (true)
            {
                Console.WriteLine("Choose Option To Perform the Operation\n1.First Name\n2.Lats Name\n3.Email\n4.Phone Number\n5.Password Rule-1\n6.Password Rule-2\n7.Password Rule-3\n8.Password Rule-4\n9.All Emails\n10.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                UserRegistration user = new UserRegistration();
                switch (option)
                {
                    case 1:
                        valid.ValidateFirstName();
                        break;
                        case 2:
                            valid.ValidateLastName();
                        break;
                        case 3:
                            valid.ValidateEmail();
                        break;
                        case 4:
                        valid.ValidatePhone();
                        break;
                        case 5:
                        valid.ValidatePasswordRule1();
                        break;
                        case 6:
                            valid.ValidatePasswordRule2();
                        break;
                        case 7:
                        valid.ValidatePasswordRule3();
                        break;
                        case 8:
                        valid.ValidatePasswordRule4();
                        break;
                        case 9:
                        valid.ValidateAllEmails();
                        break;
                     case 10:
                        flag = false;
                        break;
                }
            }
        }
    }
}
