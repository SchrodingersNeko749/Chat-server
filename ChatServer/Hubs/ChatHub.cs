using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ChatServer.DTOs;
using ChatServer.Models;
using ChatServer.Services;
using System.Linq;
namespace ChatServer.Hubs
{
    public class ChatHub : Hub
    {   
        private static Server _server = new Server();
        public ChatHub()
        {
            _server = new Server();
        }

        public async Task SendMessage(int id, string target, string message)
        {
            await Clients.Group($"user_{target}").SendAsync("ReceiveMessage", _server.GetUser(id).Name, message);
        }
        public async void Login(LoginRequestDTO login_req)
        {
            User u = _server.Login(login_req);
            if(u != null)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, $"user_{login_req.Username}");
                await Clients.Group($"user_{u.Name}").SendAsync("LoginResponse", u);
            }
        }
        // public async void CreateAccount(LoginRequestDTO login_req)
        // {
            
        // }
    }
}