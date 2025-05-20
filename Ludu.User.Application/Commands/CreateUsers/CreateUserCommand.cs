using Ludu.User.Application.Commons;

namespace Ludu.User.Application.Commands.CreateUsers;
public class CreateUserCommand : ICommand<Guid>
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

