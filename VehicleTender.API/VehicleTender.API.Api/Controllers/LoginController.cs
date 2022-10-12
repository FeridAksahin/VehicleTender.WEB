using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleTender.API.Api.Models;
using VehicleTender.API.Api.TokenHandler;
using VehicleTender.API.Api.ViewModel;
using VehicleTender.API.Common.CustomHTTPResponse;
using VehicleTender.API.Common.CustomHTTPResponse.Concrete;
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
        private readonly ILogger<LoginController> _hede;


        public LoginController(VehicleTenderContext content, IConfiguration configuration, ILogger<LoginController> hede)
        {
            _context = content;
            _configuration = configuration;
            _hede = hede;
        }
        [HttpPost]
        [Route("SignIn")]
        public async Task<StatusGenerator> SignIn([FromBody] UserSignInViewModel Singuser)
        {
            User user = new User();
            user.Name = Singuser.Name;
            user.UserName = Singuser.UserName;
            user.Mail = Singuser.Mail;
            user.Password = Singuser.Password;
            _context.User.Add(user);
            CustomResponse customResponse;
            //custom response ile client tarafına istenilen response türü ve overloadı seçilip gönderme
            using (customResponse = new CustomResponse())
            {
                return await _context.SaveChangesAsync() >= 0 ? customResponse.ResponseForDeleteOrPutOrPostRequest(200) :
            customResponse.ResponseForDeleteOrPutOrPostRequest(500);
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<Token> Login([FromBody] UserLoginDto userLogin)
        {
            User user = await _context.User.FirstOrDefaultAsync(u => userLogin.Password == u.Password);
            if (user != null)
            {
                //Token üretiliyor.
                TokenHandlerCustom tokenHandler = new TokenHandlerCustom(_configuration);
                Token token = tokenHandler.CreateAccessToken(user);

                //Refresh token Users tablosuna işleniyor.
                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenEndDate = token.Expiration.AddMinutes(5);
                await _context.SaveChangesAsync();

                return token;
            }
            return null;
        }


        [HttpGet]
        [Route("RefreshLogin")]
        public async Task<Token> RefreshTokenLogin([FromBody] string refreshToken)
        {
            User user = await _context.User.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);
            if (user != null && user?.RefreshTokenEndDate > DateTime.Now)
            {
                TokenHandlerCustom tokenHandler = new TokenHandlerCustom(_configuration);
                Token token = tokenHandler.CreateAccessToken(user);

                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenEndDate = token.Expiration.AddMinutes(3);
                await _context.SaveChangesAsync();

                return token;
            }
            return null;
        }


        [HttpGet("")]
        public IActionResult GetIndex()
        {
            StatusGenerator statusGenerator = new StatusGenerator();
            return Ok(statusGenerator.GetHttpStatusCodes(200));
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
