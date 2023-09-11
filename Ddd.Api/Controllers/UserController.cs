using Ddd.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ddd.Api.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    [HttpGet()]
    public User GetUser()
    {
        User user = new User();
        return user;
    }
}