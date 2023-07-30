using Microsoft.AspNetCore.SignalR;
using SinalingServer.Domain;
using SinalingServer.Interfaces;

namespace SinalingServer.Hubs
{
    public class HomeHub : Hub<IHome>
    {

        [HubMethodName("SendConnectionDetails")]
        public async Task OnReceiveConnectionDetails(ConnectionDetails connectionDetails) {
            await Groups.AddToGroupAsync(Context.ConnectionId, connectionDetails.IPHash);
            await Clients.OthersInGroup(connectionDetails.IPHash).ShareConnectionDetailsToAllClients(connectionDetails);
        }

    }
}
