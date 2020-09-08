using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repositoory;

        public UserService(IRepository<UserEntity> repository)
        {
            this._repositoory = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repositoory.DeleteAsync(id);
        }

        public async Task<UserEntity> Get(Guid id)
        {
            return await _repositoory.SelectAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _repositoory.SelectAsync();
        }

        public async Task<UserEntity> Post(UserEntity user)
        {
            return await _repositoory.InsertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repositoory.UpdateAsync(user);
        }
    }
}
