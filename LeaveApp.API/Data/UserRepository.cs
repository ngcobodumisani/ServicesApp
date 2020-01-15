using System.Collections.Generic;
using System.Threading.Tasks;
using LeaveApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveApp.API.Data
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            this._context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(r => r.Photos).Include(r => r.Leaves).Include(r => r.LeaveAvailables).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(r => r.Photos).Include(r => r.Leaves).Include(r => r.LeaveAvailables).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;

        }
    }
}