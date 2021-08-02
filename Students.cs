using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationsMVCDemo.Models
{
    public class Students
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Roll no is primary key its required ")]
        public int Rollno { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Name is compulsory")]
        [MinLength(3,ErrorMessage ="Name is too small")]
        [DataType(DataType.Text,ErrorMessage ="Only text data")]
        [MaxLengthAttribute(30,ErrorMessage ="Name is too big")]
        public string StudName { get; set; }
        [Required(ErrorMessage ="Grade is requried")]
        
        public int Grade { get; set; }
        [EmailAddress(ErrorMessage ="Pls enter valid email id")]
        [Required(ErrorMessage ="Required Emial")]
        public string Email { get; set; }
        

    }
}