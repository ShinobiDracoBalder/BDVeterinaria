using BDV.DataContext.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BDV.DataContext.IOC.Dependencies
{
    public static class Dependecia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<BdveterinariaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            //services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddScoped<IVentaRepository, VentaRepository>();
            //services.AddScoped<ICorreoService, CorreoService>();
            //services.AddScoped<IFireBaseService, FireBaseService>();
            //services.AddScoped<IUtilitiesService, UtilitiesService>();
            //services.AddScoped<IRolService, RolService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<INegocioService, NegocioService>();
        }
    }
}
