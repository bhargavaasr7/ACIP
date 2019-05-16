using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ACIP.Models
{
    public class registration
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="FirstName Required")]
        [StringLength(20,ErrorMessage ="FirstName can't exceed morethan 20 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="LastName Required")]
        [StringLength(20,ErrorMessage ="LastName can't exceed morethan 20 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="age required")]
        public int age { get; set; }
        [Required(ErrorMessage ="mobile number required")]
        public string mobile { get; set; }
        [Required(ErrorMessage ="Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="please enter username")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="please enter password")]
        public string Password { get; set; }
    }
}