using CompleteDeveloperNetwork.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteDeveloperNetwork.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly DapperDBContext _context;

        public UserRepo(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<User>("SELECT * FROM Users");
            }
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<User>("SELECT * FROM Users WHERE UserId = @Id", new { Id = id });
            }
        }

        public async Task AddUserAsync(User user)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "INSERT INTO Users (Username, Email, PhoneNumber, SkillSets, Hobby) VALUES (@Username, @Email, @PhoneNumber, @SkillSets, @Hobby)";
                await connection.ExecuteAsync(query, user);
            }
        }




        public async Task UpdateUserAsync(User user)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "UPDATE Users SET Username = @Username, Email = @Email, PhoneNumber = @PhoneNumber, SkillSets = @SkillSets, Hobby = @Hobby WHERE UserId = @UserId";
                await connection.ExecuteAsync(query, user);
            }
        }

        public async Task DeleteUserAsync(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync("DELETE FROM Users WHERE UserId = @Id", new { Id = id });
            }
        }
    }
}
