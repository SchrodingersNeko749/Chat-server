using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatServer.Models
{
    [Table("Message")]
    public class Message
    {
        [Key()]
        public Guid Id {get; set;}
        public string Text {get; set;}
    }
}