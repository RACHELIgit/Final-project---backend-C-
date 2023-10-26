using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services_Bll.interfaces;
using Common_DTO.DTOs;
using AutoMapper;
using Repositories.Entities;
using Repositories.Interfaces;

namespace Services_Bll.Bll
{
    public class userService: IService<UsersDto>
    {
        private readonly IReporsetories<Users> _uesrRepository;
        private readonly IMapper _mapper;
        public userService(IReporsetories<Users> rep, IMapper mapper)
        {
            _uesrRepository = rep;
            _mapper = mapper;
        }

        public Task<UsersDto> AddAsync(UsersDto entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UsersDto>> GetAllAsync()
        {
         List<Users> u=  await _uesrRepository.GetAllAsync();
           return _mapper.Map<List<UsersDto>>(u);
        }

        public Task<UsersDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsersDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<UsersDto> UpdateAsync(UsersDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
