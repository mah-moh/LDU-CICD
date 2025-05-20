using FluentValidation;
using Ludu.User.Domain.Repositories;
using MediatR;

namespace Ludu.User.Application.Commands.CreateUsers;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly ICreateUserRepository _repository;

    public CreateUserCommandHandler(ICreateUserRepository repository, IValidator<CreateUserCommand> validator)
    {
        _repository = repository;
    }
    public async Task<Guid> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        return Guid.Empty;
    }
}

