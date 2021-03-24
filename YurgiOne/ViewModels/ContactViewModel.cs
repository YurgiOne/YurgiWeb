using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurgiOne.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string Message { get; set; }
        [Required]
        public string Subject { get; set; }


    }
}
