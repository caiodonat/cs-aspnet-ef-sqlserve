using Ddd.Domain.Entities;
using Ddd.Domain.Interfaces;

namespace Ddd.Domain.Services;

public class UserService : IUserService
{
	public User GetById( int id)
	{
		return new User();
	}
}
