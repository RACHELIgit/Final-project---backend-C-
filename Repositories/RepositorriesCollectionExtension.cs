using Microsoft.Extensions.DependencyInjection;
using Repositories.Entities;
using Repositories.Interfaces;
using Repositories.Reposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class RepositorriesCollectionExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
       
            services.AddScoped<IReporsetories<ItemToCategory>, ItemToCategoryRep>();
            services.AddScoped<IReporsetories<Users>,UsersRep >();
          

        }



    }

}