using Ddd.Domain.Entities;
using Ddd.Infrastructure.Data;
using Ddd.Infrastructure.Interfaces;

namespace Ddd.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
	private readonly AppDbContext _dbContext;

	public UserRepository(AppDbContext sqlContext)
	{
		_dbContext = sqlContext;
	}

	public User SelectById(int id){
		return _dbContext.Users.FirstOrDefault(x => x.Id == id);
	}

	public List<User> SelectAll(){
		return _dbContext.Users.Where(x => x.Id != 0).ToList();
	}

    // IEnumerable<User> IUserRepository.SelectAll()
    // {
    //     throw new NotImplementedException();
    // }
}