using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Reposities
{
    internal class ItemToCategoryRep : IReporsetories<ItemToCategory>
    {
        private readonly IContext context;
        public ItemToCategoryRep(IContext context)
        {
            this.context = context;
        }

        public Task<ItemToCategory> AddAsync(ItemToCategory entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemToCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ItemToCategory> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ItemToCategory> UpdateAsync(ItemToCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
