using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Interfaces;
using Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Repositories.Reposities
{
    internal class UsersRep:IReporsetories<Users> {

        private readonly IContext context;
        public UsersRep(IContext context)
        {
            this.context = context;
        }

        public async Task<Users> AddAsync(Users entity)
        {
            ValueTask<EntityEntry<Users>> newOne = this.context.Users.AddAsync(entity);

            await context.SaveChangesAsync();

            return newOne.Result.Entity;
        }

        public  async Task DeleteAsync(int id)
        {

            var c = await GetByIdAsync(id);
            context.Users.Remove(c);
            await context.SaveChangesAsync();
        }

        public async Task<List<Users>> GetAllAsync()
        {
            try
                {
            return await context.Users.Include(y=>y.Occupation).ToListAsync();

            }
            catch (Exception e){
                return null;
            }
        }

        public async Task<Users> GetByIdAsync(int id)
        {
            return await context.Users.SingleAsync(c => c.UsersId == id);

        }



        public async Task<Users> UpdateAsync(Users entity)
        {
            var c = context.Users.Update(entity);
            await context.SaveChangesAsync();
            return c.Entity;
        }
    }
}
