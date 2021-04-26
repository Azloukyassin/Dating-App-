using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/controller")]
  public class UsersController : ControllerBase
  {
    public DataContext _Context ;
    public UsersController(DataContext context)
    {
      this._Context = context;
    }
    // api/users/3
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() 
    {
        var users = await _Context.Users.ListAsync(); 
        return users; 
    }
     [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(int id) 
    {
        var users =  await _Context.Users.FindAsync(); 
        return users; 
    }
  }
}