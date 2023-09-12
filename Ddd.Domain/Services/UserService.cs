using Ddd.Domain.Entities;
using Ddd.Domain.Interfaces;

// using Ddd.Infrastructure.Interfaces;

namespace Ddd.Domain.Services;

public class UserService : IUserService
{
	// private readonly IUserRepository _repository;

	// public UserService(IUserRepository userRepository)
	// {
	// 	_repository = userRepository;
	// }
	public User GetById(int id)
	{
		return new User();
		// return _repository.SelectById(id);
	}
}
