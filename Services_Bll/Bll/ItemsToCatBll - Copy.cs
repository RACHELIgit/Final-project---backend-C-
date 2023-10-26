using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services_Bll.interfaces;
using Common_DTO.DTOs;
namespace Services_Bll.Bll;

internal class ItemToCatBll : IService<ItemToCategoryDto>
{
    public Task<ItemToCategoryDto> AddAsync(ItemToCategoryDto entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ItemToCategoryDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ItemToCategoryDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ItemToCategoryDto> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<ItemToCategoryDto> UpdateAsync(ItemToCategoryDto entity)
    {
        throw new NotImplementedException();
    }
}
