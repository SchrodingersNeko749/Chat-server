using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.WebSockets;
using System.Text;
namespace ChatServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("api/sendMessage")]
        public IActionResult SendMessage(string message)
        {
            _logger.LogInformation("Message: "+message);
            return Ok();
        }
        [Route("api/login")]
        public IActionResult Login(string username, string password)
        {
            return Ok();
        }
    //views
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Chatroom()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
