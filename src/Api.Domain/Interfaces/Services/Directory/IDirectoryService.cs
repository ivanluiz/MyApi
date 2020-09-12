using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Directory
{
    public interface IDirectoryService
    {
        Task<DirectoryEntity> Get(Guid id);
        Task<IEnumerable<DirectoryEntity>> GetAll();
        Task<DirectoryEntity> Post(DirectoryEntity diretory);
        Task<DirectoryEntity> Put(DirectoryEntity diretory);
        Task<bool> Delete(Guid id);
        Task<bool> Exist(Guid id);
    }
}
