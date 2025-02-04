using Microsoft.AspNetCore.Mvc;
using jwt.Services;
using jwt.models;

namespace jwt.Controllers{

    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase{

        private readonly IUserService _repository;
        private readonly ITokenService _tokenService;

        public UserController(IUserService repository, ITokenService tokenService){
            _repository = repository;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("SignUser")]

        public async Task<IActionResult> SignUser(User user){

            var theuser = await _repository.SignUpAsync(user);
            if (theuser == null) return BadRequest("user already registered");

            return Ok(theuser);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(string Email , string Password){

            var theUser = await _repository.LoginAsync(Email, Password);

            if (theUser == null) return NotFound("no user with this email");

            var token = _tokenService.GenerateToken(theUser);
            return Ok(new { Token = token });
        }


    }
}