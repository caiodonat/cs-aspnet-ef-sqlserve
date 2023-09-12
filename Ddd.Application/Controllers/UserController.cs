using Ddd.Domain.Entities;
using Ddd.Domain.Interfaces;
using Ddd.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ddd.Api.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
	private readonly IUserService _service;
	private readonly IUserRepository _repository;

	public UserController(
		IUserService userService,
		IUserRepository userRepository
	)
	{
		_service = userService;
		_repository = userRepository;
	}

	[HttpGet("/users/all")]
	public List<User> GetAllUser(
	)
	{
		// return _service.GetById(id);
		return _repository.SelectAll();
	}

	[HttpGet("/users/{id}")]
	public User GetUser(
		[FromRoute()] int id
	)
	{
		// return _service.GetById(id);
		return _repository.SelectById(id);
	}
}