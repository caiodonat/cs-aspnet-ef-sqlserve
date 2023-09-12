using Ddd.Domain.Entities;
using Ddd.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ddd.Api.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
	private readonly IUserService _service;

	public UserController(IUserService userService)
	{
		_service = userService;
	}

	[HttpGet("/users/{id}")]
	public User GetUser([FromRoute()] int id)
	{
		return _service.GetById(id);
	}
}