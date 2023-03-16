using Microsoft.AspNetCore.SignalR;

namespace ChatSignalR.SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string userName, string message)
        {
            await Clients.All.SendAsync("sendMessage", userName, message);
        }
        public async Task UserJoinedMessage(string userName, string message)
        {
            var userJoinedMessage = $"{userName} just joined the chat!";
            await Clients.All.SendAsync("userJoinedMessage", userJoinedMessage);
        }
        public async Task UserLeftChat(string userName)
        {
            var userLeftChatMessage = $"{userName} left the chat :(";
            await Clients.All.SendAsync("userLeftChat", userLeftChatMessage);
        }
    }
}