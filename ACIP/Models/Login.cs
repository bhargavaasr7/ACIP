using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ACIP.Models
{
    public class Login
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Username Required")]
        [StringLength(20,ErrorMessage ="UserName cant exceed more than 20 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}