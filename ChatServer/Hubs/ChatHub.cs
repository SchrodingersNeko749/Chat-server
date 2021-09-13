using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ChatServer.DTOs;
using System;
namespace ChatServer.Hubs
{
    public class ChatHub : Hub
    {
        
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", "server", "message recieved");
        }
        /*
            we need a Dictionary of users. so we need to login and to login we need to send json file format from front to back. 
            
        */
        public async void Login(string login_req)
        {
            Console.WriteLine(login_req);
        }

    }
}