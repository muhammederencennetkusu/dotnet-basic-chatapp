using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRChatApp.Data;
using System.Threading.Tasks;

namespace SignalRChatApp.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ChatContext _context;

        public ChatHub(ChatContext context)
        {
            _context = context;
        }

        public async Task SendMessage(string userName, string messageContent)
        {
            var message = new Message
            {
                UserName = userName,
                MessageContent = messageContent,
                Timestamp = DateTime.Now
            };

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveMessage", userName, messageContent);
        }

          public async Task<IEnumerable<Message>> GetMessages()
         {
         return await _context.Messages.OrderBy(m => m.Timestamp).ToListAsync();
         }
    }
}
