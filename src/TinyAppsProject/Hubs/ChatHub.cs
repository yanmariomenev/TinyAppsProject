using System.Threading.Tasks;
using TinyAppsProject.Models.Chat;
using Microsoft.AspNetCore.SignalR;

namespace TinyAppsProject.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string user ,string message)
        {
            await this.Clients.All.SendAsync(
                "NewMessage",
                new Message {User = user, Text = message, });
        }
    }
}
