using SinalingServer.Domain;

namespace SinalingServer.Interfaces
{
    public interface IHome
    {
        Task ShareConnectionDetailsToAllClients(ConnectionDetails connectionDetails);
    }
}
