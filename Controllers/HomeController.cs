using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingChatService.DataBase;
using TestingChatService.Models;

namespace TestingChatService.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _ctx;

        public HomeController(AppDbContext ctx) => _ctx = ctx;
        public IActionResult Index() => View();
        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            _ctx.Chats.Add(new Chat
            {
                Name = name,
                Type = Chat.ChatType.Group
            });
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
