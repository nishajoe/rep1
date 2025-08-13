using Microsoft.EntityFrameworkCore;
using MVC_PetAppStoredProcedure.Models;
using MVC_PetAppStoredProcedure.Repository;

namespace MVC_PetAppStoredProcedure.Extension
{
    public static class ApplicationServices
    {
         public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
            {
                services.AddDbContextPool<MvcPetDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
                services.AddScoped<IPetRepository, PetRepository>();


                return services;


            }
        
    }
}
