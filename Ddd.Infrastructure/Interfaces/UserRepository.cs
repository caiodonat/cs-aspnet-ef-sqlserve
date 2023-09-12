using Ddd.Domain.Entities;

namespace Ddd.Infrastructure.Interfaces;

public interface IUserRepository
{
	public User SelectById(int id);
	public List<User> SelectAll();
}
