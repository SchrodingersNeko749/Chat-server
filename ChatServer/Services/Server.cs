using ChatServer.DTOs;
using ChatServer.Entities;
using System.Collections.Generic;
namespace ChatServer.Services
{
    class Server
    {
        private Dictionary<int,User> _users = new Dictionary<int,User>();
        private Dictionary<int,Conversation> _conversations = new Dictionary<int,Conversation>();

        public Server()
        {
            _users.Add(0, new User("neko", "neko"));
            _users.Add(1, new User("alu", "alu"));
            _users[0].AddContact(_users[1]);
            _users[1].AddContact(_users[0]);
            Conversation convo = new Conversation(0,1);
            MessageDTO msg = new MessageDTO(1, "testing message: hi neko", 0);
            convo.AddMessage(msg);
            _conversations.Add(_conversations.Count, convo);
        }
        public int AddUser(User u)
        {
            int id = -1;
            if(!_users.ContainsValue(u))
            {
                _users.Add(_users.Keys.Count, u);
                id = _users.Keys.Count;
            }
            return id;
        }
        public bool UserExists(User u)
        {
            if(_users.ContainsValue(u))
                return false;
            else
                return true;
        }
        public User GetFirstUser()
        {
            return _users[0];
        }
        public int FindId(string username)
        {
            int id = -1;
            foreach (var kvp in _users)
            {
                if(kvp.Value.Name == username)
                {
                    id = kvp.Key;
                    return id;
                }
            }
            return id;
        }
        public User FindUser(int id)
        {
            return _users[id];
        }
    }
}