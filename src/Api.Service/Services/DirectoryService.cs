using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Directory;

namespace Api.Service.Services
{
    public class DirectoryService : IDirectoryService
    {
        private IRepository<DirectoryEntity> _repository;

        public DirectoryService(IRepository<DirectoryEntity> repository)
        {
            this._repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<DirectoryEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<DirectoryEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<DirectoryEntity> Post(DirectoryEntity directory)
        {
            return await _repository.InsertAsync(directory);
        }

        public async Task<DirectoryEntity> Put(DirectoryEntity directory)
        {
            return await _repository.UpdateAsync(directory);
        }

        public async Task<bool> Exist(Guid id)
        {
            return await _repository.ExistAsync(id);
        }
    }
}
