using Microsoft.EntityFrameworkCore;
namespace ChatServer.Models
{
    public class ChatServerContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=Chatroom.db");
    }
    public DbSet<Message> Message{ get; set;}
    public DbSet<User> User{get; set;}
}
}