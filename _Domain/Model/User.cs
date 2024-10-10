using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _Domain.Model
{
    public class User
    {
        [Key]
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}