using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatServer.Models
{
    [Table("User")]
    public class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        [Key()]
        public int Id {get; set;}
        public string Name {get; set;}
        public string Password {get; set;}
        public List <int> _contacts_ID = new List<int>();
    }
}