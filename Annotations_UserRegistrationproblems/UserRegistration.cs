using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations_UserRegistrationproblems
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "User Deatils {0} is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "First Name Sholud contain Minimum 3 Characters and Max.100")]
      //[DataType(DataType.Text)]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "First Letter Starts  With Cap and has Minimum 3 Charcters.")]
        public string First_Name { get; set; }      
    }
    public class ValidateLastName
    {
        [Required(ErrorMessage = "User Deatils {0} is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Last Name Sholud contain Minimum 3 Characters and Max.100")]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "First Letter Starts  With Cap and has Minimum 3 Charcters.")]
        public string Last_Name { get; set; }
    }
    public class ValidateEmail
    {
        //[Required(ErrorMessage ="User Deatils {0} is Required")]
        //[StringLength(100, MinimumLength =4,ErrorMessage = "(E.g. abc.xyz@bl.co.in)Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions")]
        //[RegularExpression("^[A-Za-z0-9]{3,}[.]{1}[a-z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}",ErrorMessage ="The Email Sholud Contain @ Symbol")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
    public class ValidatePhoneNumber
    {
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }
    }
    public class ValidatePasswordRule1
    {
        [Required(ErrorMessage ="User Deatils {0} is Required")]
        [StringLength(100, MinimumLength =8,ErrorMessage = "Password Rule 1 Need Minimum 8 Characters")]
        [RegularExpression("^[A-Z]{8,}$", ErrorMessage = "Password to be Enterd All Captial Letters Minumum 8 Characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class ValidatePasswordRule2
    {
        [Required(ErrorMessage = "User Deatils {0} is Required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password Rule 2 Need Minimum 8 Characters")]
        [RegularExpression("^[A-Z]{1,}[a-z0-9]{7,}$", ErrorMessage = "Password Sholud have At Least 1 Upper Case (Minumum 8 Characters)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class ValidatePasswordRule3
    {
        [Required(ErrorMessage = "User Deatils {0} is Required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password Rule 3 Need Minimum 8 Characters")]
        [RegularExpression("^[A-Z]{1,}[a-z]{3,}[0-9]{4,}$", ErrorMessage = "Password Sholud have At Least 1 Upper Case (Minumum 8 Characters)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
