using MediatR;

namespace Ludu.User.Application.Commons;

public interface IQuery<out TResult> : IRequest<TResult>;

