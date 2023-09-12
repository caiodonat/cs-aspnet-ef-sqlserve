using Ddd.Domain.Entities;

namespace Ddd.Domain.Interfaces;

public interface IUserService
{
	User GetById(int id);
	
}
