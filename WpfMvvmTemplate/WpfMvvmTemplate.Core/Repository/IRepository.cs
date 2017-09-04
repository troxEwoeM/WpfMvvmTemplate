namespace WpfMvvmTemplate.Core.Repository
{
    using System.Threading.Tasks;
    using Model;

    public interface IRepository
    {
        Task<bool> ConnectAsync(RepositoryConnectionParameters parameters);
        Task<bool> DisconnectAsync();

        bool Connect(RepositoryConnectionParameters parameters);
        bool Disconnect();
    }
}