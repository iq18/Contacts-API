using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class Contact
    {
        [Key]
        public int PMId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; } //MM/YY

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
    }
}
