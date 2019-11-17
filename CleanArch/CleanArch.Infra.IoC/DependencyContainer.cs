using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMediatorHandler, InMemoryBus>();
            serviceCollection.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            serviceCollection.AddScoped<ICourseService, CourseService>();
            serviceCollection.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
