using CompleteDeveloperNetwork.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompleteDeveloperNetwork.Repo
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
