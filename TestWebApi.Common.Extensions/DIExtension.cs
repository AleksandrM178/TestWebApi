using Microsoft.Extensions.DependencyInjection;
using TestWebApi.BLL.Logic.Contracts.User;
using TestWebApi.BLL.Logic.User;
using TestWebApi.DAL.Repositories.Contracts.User;
using TestWebApi.DAL.Repositories.User;

namespace TestWebApi.Common.Extensions
{
    public static class DIExtension
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IUserLogic, UserLogic>();
            return services;
        }

        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
