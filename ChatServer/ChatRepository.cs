using ChatServer.Models;
using ChatServer.DTOs;
using System.Linq;
namespace ChatServer
{
    public class ChatroomRepository
    {
        private readonly ChatServerContext _context;
        public ChatroomRepository()
        {
            _context = new ChatServerContext();
        }
        public User FindUserByLoginRequest(LoginRequestDTO req)
        {
            var u = _context.User.Single(u => u.Name == req.Username && u.Password == req.Password);
            return u;
        }
        public User FindUser(int id)
        {
            return _context.User.Find(id);
        }
        public bool UsernameExists(string name)
        {
            return _context.User.Any(u => u.Name == name);
        }
        public User AddUser(LoginRequestDTO req)
        {
            var u = new User(req.Username, req.Password);
            _context.User.Add(u);
            _context.SaveChanges();
            return u;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}