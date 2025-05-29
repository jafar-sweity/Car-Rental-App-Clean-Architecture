using CarRentalApp.Infrastructure;

namespace CarRentalApp.Core.InterfacesRepository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
