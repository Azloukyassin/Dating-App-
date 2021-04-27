using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

  public class UsersController : BaseAPIController
  {
    public DataContext _Context ;
    public UsersController(DataContext context)
    {
      this._Context = context;
    }
    // api/users/3
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() 
    {
        var users = await _Context.Users.ListAsync(); 
        return users; 
    }
     [Authorize]
     [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(int id) 
    {
        var users =  await _Context.Users.FindAsync(); 
        return users; 
    }
  }
}