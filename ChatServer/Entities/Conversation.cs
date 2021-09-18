using System.Collections.Generic;
using ChatServer.DTOs;
namespace ChatServer.Entities
{
    public class Conversation
    {
        List<MessageDTO> _messages = new List<MessageDTO>();   
        int[] UserIds = new int[2];
        public Conversation(int userid1, int userid2)
        {
            UserIds[0] = userid1;
            UserIds[1] = userid2;
        }
        public void AddMessage(MessageDTO message)
        {
            _messages.Add(message);
        }
    }
}