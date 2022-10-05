using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleTender.API.Api.TokenHandler;
using VehicleTender.API.Api.ViewModel;
using VehicleTender.API.Entity.Context;
using VehicleTender.API.Entity.Entities;

namespace VehicleTender.API.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        readonly VehicleTenderContext _context;
        readonly IConfiguration _configuration;
        public LoginController(VehicleTenderContext content, IConfiguration configuration)
        {
            _context = content;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("SignIn")]
        public async Task<bool> SignIn([FromBody] UserSignInViewModel Singuser)
        {
            VehicleTender.API.Entity.Entities.User user = new User();
            user.Name = Singuser.Name;
            user.UserName = Singuser.UserName;
            user.Mail = Singuser.Mail;
            user.Password = Singuser.Password;
            _context.User.Add(user);

            await _context.SaveChangesAsync();
            return true;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<Models.Token> Login([FromBody] UserLoginDto userLogin)
        {
            User user = await _context.User.FirstOrDefaultAsync(u => userLogin.Password == u.Password);
            if (user != null)
            {
                //Token üretiliyor.
                TokenHandlerCustom tokenHandler = new TokenHandlerCustom(_configuration);
                Models.Token token = tokenHandler.CreateAccessToken(user);

                //Refresh token Users tablosuna işleniyor.
                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenEndDate = token.Expiration.AddMinutes(5);
                await _context.SaveChangesAsync();

                return token;
            }
            return null;
        }


        [HttpGet("[action]")]
        public async Task<Models.Token> RefreshTokenLogin([FromBody] string refreshToken)
        {
            User user = await _context.User.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);
            if (user != null && user?.RefreshTokenEndDate > DateTime.Now)
            {
                TokenHandlerCustom tokenHandler = new TokenHandlerCustom(_configuration);
                Models.Token token = tokenHandler.CreateAccessToken(user);

                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenEndDate = token.Expiration.AddMinutes(3);
                await _context.SaveChangesAsync();

                return token;
            }
            return null;
        }

        private readonly ILogger<LoginController> _hede;
        public LoginController(ILogger<LoginController> hede)
        {
            _hede = hede;
        }
        [HttpGet("")]
        public IActionResult GetIndex()

        {
            return Ok();
        }
        [HttpPut("")]
        public IActionResult PutIndex()
        {
            return Ok();
        }
        [HttpPost("")]
        public IActionResult PostIndex()
        {
            return Ok();
        }
        [HttpDelete("")]
        public IActionResult DeleteIndex()
        {
            return Ok();
        }
    }
}
