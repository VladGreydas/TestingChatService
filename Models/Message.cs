using System;

namespace TestingChatService.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
