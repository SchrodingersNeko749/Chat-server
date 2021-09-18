using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ChatServer.DTOs;
using ChatServer.Entities;
using ChatServer.Services;
namespace ChatServer.Hubs
{
    public class ChatHub : Hub
    {   
        Server _server = new Server();
        public async Task SendMessage(int id, string target, string message)
        {
            await Clients.Group($"user_{target}").SendAsync("ReceiveMessage", _server.FindUser(id).Name, message);
        }
        public async void Login(LoginRequestDTO login_req)
        {
            var id = -1;
            var u = new User(login_req.Username, login_req.Password);
            if(_server.UserExists(u))
            {
                id = _server.FindId(login_req.Username);
                await Groups.AddToGroupAsync(Context.ConnectionId, $"user_{login_req.Username}");
                await Clients.Group($"user_{login_req.Username}").SendAsync("LoginResponse", id, login_req.Username, $"welcome back {login_req.Username}");
                
            }
            else
            {
                _server.AddUser(u);
                await Clients.Group($"user_{login_req.Username}").SendAsync("LoginResponse", id, login_req.Username, $"welcome back {login_req.Username}");
            }
        }
        public async void GetContacts(int id)
        {
            var u = _server.FindUser(id);
            await Clients.Group($"user_{u.Name}").SendAsync("RecieveContacts", u.GetContactNames());
        }

    }
}