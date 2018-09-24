using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Owner
    {
        public int Id { get; set; }
        [Required (ErrorMessage="Please fill up the Name ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill up the Email "), EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please fill up the Username ")]
        public string Username { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Please fill up the Phone "), Phone]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please fill up the Address "), MaxLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please fill up the Area "), MaxLength(20)]
        public string Area { get; set; }
    }
}
