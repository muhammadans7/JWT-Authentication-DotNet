using jwt.models;

namespace jwt.Services{

    public interface IUserService{

        Task<User> SignUpAsync(User user);

        Task<User> LoginAsync(string Email , string Password);
    }
}