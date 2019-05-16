using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ACIP.Models
{
    public class LoginWithOutCredentials
    {
        public int id { get; set; }
        [Required(ErrorMessage ="please enter your policyId")]
        public string PolicyId { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="please enter your mobile number")]
        public int mobile { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "please enter your EmailId")]
        public string EmailId { get; set; }
    }
}