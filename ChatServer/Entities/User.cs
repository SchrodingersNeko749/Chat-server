using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChatServer.Entities
{
    class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public string Name {get; set; }
        public string Password {get; set;}
        private Dictionary <int, User> _contacts = new Dictionary<int, User>();
        public User GetContactByName(string name)
        {
            return _contacts.Single(kvp => kvp.Value.Name == name).Value;
        }
        public void AddContact(User u)
        {
            _contacts.TryAdd(_contacts.Count, u);
        }
        public List<string> GetContactNames()
        {
            List<string> contact_names = new List<string>();
            foreach (var kvp in _contacts)
            {
                contact_names.Add(kvp.Value.Name);
            }
            return contact_names;
        }
    }
}