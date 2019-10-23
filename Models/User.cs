using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace ApiWithAjax.Models
{
    public class User 
    { 
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string FullName { get; set; }
        [Required]
        [StringLength(250)]
        public string UserName { get; set; }
        [Required]
        [StringLength(250)]
        public string Password { get; set; }
         
    }
}

