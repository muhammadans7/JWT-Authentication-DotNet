using jwt.data;
using jwt.models;
using Microsoft.EntityFrameworkCore;

namespace jwt.Services{

    public class UserService : IUserService{

        private readonly AppDbContext _context = new();

        public async Task<User> SignUpAsync(User user){

            var theUser = await _context.Users.FirstOrDefaultAsync(i => i.Email == user.Email);
            if (theUser == null)
            {

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return user;

            }
            else return null;

        }

        public async Task<User> LoginAsync(string Email, string password){

            var theUser = await _context.Users.FirstOrDefaultAsync(e => e.Email == Email && e.Password == password);
            if (theUser != null) return theUser;
            return null;
        }
    }
}