using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Renter
    {

        
        public int Id { get; set; }
       [Required]
        public string Name { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
