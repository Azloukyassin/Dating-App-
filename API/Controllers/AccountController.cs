using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using API.DTOs;
using System.Text;
using API.Interfaces;

namespace API.Controllers
{
  public class AccountController : BaseAPIController
  {

    public DataContext _Context { get; }
    public ITokenService _TokenService { get; }

    public AccountController(DataContext context, ITokenService tokenService)
    {
      _TokenService = tokenService;
      _Context = context;
    }
    [HttpPost("register")]
    public async Task<ActionResult<UserDto>> Register(RegisterDto resgiterDto)
    {
      if (await UserExists(resgiterDto.Userrname)) return BadRequest("Username is taken !");

      using var hmac = new HMACSHA512();
      var user = new AppUser
      {
        Username = resgiterDto.Userrname,
        PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(resgiterDto.Password)),
        PasswordSalt = hmac.Key
      };
      _Context.Users.Add(user);
      await _Context.SaveAsyncChange();
      return new UserDto {
          Username = user.Username, 
          Token =  _TokenService.CreateToken(user)
      }; 

    }
    [HttpPost("Login")]
    public async Task<ActionResult<AppUser>> Login(LoginDto loginDto)
    {
      var user = await _Context.Users.SingleOrDefaultAsync(x => x.Username = loginDto.Username);
      if (user == null) return Unauthorized("Invalid username !");

      using var hmac = new HMACSHA512(user.PasswordSalt);
      var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
      for (int i = 0; i < computedHash.Length; i++)
      {
        if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid passord");
      }
      return null;
    }
    private async Task<bool> UserExists(string username)
    {
      return await _Context.Users.AnyAsync(x => x.Username == username.ToLower());
    }

  }
}