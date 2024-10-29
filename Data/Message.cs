using System;

namespace SignalRChatApp.Data
{
    public class Message
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string MessageContent { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
