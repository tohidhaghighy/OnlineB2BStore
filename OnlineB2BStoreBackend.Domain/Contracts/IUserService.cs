using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Domain.Contracts
{
    public interface IUserService
    {
        Task<List<User>> GetUserList();
        Task<User> GetUser(int id);
        Task<int> InsertUser(User user);
        Task<User> UpdateUser(User user);
    }
}
