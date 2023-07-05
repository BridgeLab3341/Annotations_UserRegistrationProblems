using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations_UserRegistrationproblems
{
    internal class UserRegistration
    {
        [Required(ErrorMessage = "User Deatils {0} is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Sholud contain Minimum 3 Characters and Max.100")]
      //[DataType(DataType.Text)]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "First Letter Starts  With Cap and has Minimum 3 Charcters.")]
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
    }
}
