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
                Console.WriteLine("Choose Option To Perform the Operation\n1.First Name\n2.Lats Name\n3.Email\n4.Phone Number\n5.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}
