namespace Ddd.Domain.Entities;

public class User
{

    public User()
    {
        Id = 0;
        Name = "";
        Registration = "";
    }
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Registration { get; set; }
}
