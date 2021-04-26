using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestingChatService.DataBase;

namespace TestingChatService.RoomViewComponents
{
    public class RoomViewComponent : ViewComponent
    {
        private AppDbContext _ctx;

        public RoomViewComponent(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public IViewComponentResult Invoke()
        {
            var chats = _ctx.Chats.ToList();
            return View(chats);
        }
    }
}