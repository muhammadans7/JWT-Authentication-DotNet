using jwt.models;
namespace jwt.Services{

    public interface ITokenService{

        string GenerateToken(User user);
    }
}

// no public static in interface