using Microsoft.AspNetCore.SignalR;

namespace SinalingServer.Hubs
{
    public class HomeHub : Hub
    {

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("HelloWorld", $"Olá, mundo! ID:{Context.ConnectionId}");
        }
    }
}
