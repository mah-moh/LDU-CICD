using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Ludu.User.Application.Commands.CreateUsers;
using Microsoft.Extensions.DependencyInjection;

namespace Ludu.User.Application;

public static class ServiceConfiguration
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();

        services.AddFluentValidationAutoValidation();

        return services;
    }
}