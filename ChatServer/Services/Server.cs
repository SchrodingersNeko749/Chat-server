using System;
using ChatServer.DTOs;
using ChatServer.Models;
using System.Collections.Generic;
using System.Linq;
namespace ChatServer.Services
{
    class Server
    {
        private readonly ChatroomRepository _repo;
        public Server()
        {
            _repo = new ChatroomRepository();
            var neko = CreateAccount(new LoginRequestDTO("neko","neko"));
            CreateAccount(new LoginRequestDTO("alu","alu"));
            neko._contacts_ID.Add(2);
            _repo.SaveChanges();
        }
        public User Login(LoginRequestDTO req)
        {
            return _repo.FindUserByLoginRequest(req);
        }
        public User GetUser(int id)
        {
            return _repo.FindUser(id);
        }
        public User CreateAccount(LoginRequestDTO req)
        {
            if(!_repo.UsernameExists(req.Username))
            {
                return _repo.AddUser(req);
            }
            else
            {
                return _repo.FindUserByLoginRequest(req);
            }
        }
        public void AddContact()
        {
            
        }
    }
}