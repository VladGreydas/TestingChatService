using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingChatService.Models
{
    public partial class Chat
    {
        public int ID { get; set; }
        public ChatType Type { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<User> Users { get; set; }
        public string Name { get; set; }
    }
}
