namespace ChatServer.DTOs
{
    public record MessageDTO
    {
        public int UserId {get; set;}
        public string Message {get; set;}
        public int TargetUser {get; set;}
        public MessageDTO(int userid, string message, int targetid)
        {
            UserId = userid;
            Message = message;
            TargetUser = targetid;
        }
    }
}