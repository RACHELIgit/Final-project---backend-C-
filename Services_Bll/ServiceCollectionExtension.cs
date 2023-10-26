using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Repositories;
using System.Text;
using System.Threading.Tasks;
using Services_Bll.interfaces;
using Services_Bll.Bll;
using Common_DTO.DTOs;
using Context_dal;
namespace Services_Bll
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<ItemToCategoryDto>, ItemToCatBll> ();
            services.AddScoped<IService<UsersDto>, userService>();
            services.AddSingleton<IContext,TravelOrganizationContext >();
            services.AddAutoMapper(typeof(Mapper));

        }
    }
}