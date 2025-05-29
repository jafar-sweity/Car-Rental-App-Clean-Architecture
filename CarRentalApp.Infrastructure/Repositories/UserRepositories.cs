using CarRentalApp.Core.InterfacesRepository;
using CarRentalApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Infrastructure.Repositories
{
    public class UserRepositories : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepositories(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddUserAsync(User user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the user.", ex);
            }
        }

        public async Task DeleteUserAsync(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id) ?? throw new KeyNotFoundException("User not found.");
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the user.", ex);
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all users.", ex);
            }
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);
                return user == null ? throw new KeyNotFoundException("User not found.") : user;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the user by ID.", ex);
            }
        }

        public Task UpdateUserAsync(User user)
        {
            try
            {
                var existingUser = _context.Users.Find(user.Id) ?? throw new KeyNotFoundException("User not found.");
                _context.Users.Update(user);
                return _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the user.", ex);
            }
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
                return user == null ? throw new KeyNotFoundException($"User with email {email} not found.") : user;
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching user by email.", ex);
            }
        }
    }
}
