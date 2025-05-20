using MediatR;

namespace Ludu.User.Application.Commons;

public interface ICommand<out TResult> : IRequest<TResult>;

