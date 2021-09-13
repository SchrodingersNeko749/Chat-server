using System.Linq;
using System.Collections.Generic;
namespace ChatServer.Entities
{
    class User
    {
        public string Name {get; set; }
        private Dictionary <int, User> Contacts = new Dictionary<int, User>();
        public User GetContactByName(string name)
        {
            return Contacts.Single(kvp => kvp.Value.Name == name).Value;
        }
    }
}