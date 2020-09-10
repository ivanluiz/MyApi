using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.GeometricForm;

namespace Api.Service.Services
{
    public class GeometricFormService : IGeometricFormService
    {
        private IRepository<GeometricFormEntity> _repository;

        public GeometricFormService(IRepository<GeometricFormEntity> repository)
        {
            this._repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<GeometricFormEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<GeometricFormEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        //private IRepository<DirectoryEntity> _repositoryDiretory;
        public async Task<GeometricFormEntity> Post(GeometricFormEntity GeometricForm)
        {
            //var retorno = await _repositoryDiretory.SelectAsync(GeometricForm.Directory.Id);
            //if (retorno != null)
            return await _repository.InsertAsync(GeometricForm);
            //else
            //throw new Exception("Diretório não foi encontrado!");
        }

        public async Task<GeometricFormEntity> Put(GeometricFormEntity GeometricForm)
        {
            return await _repository.UpdateAsync(GeometricForm);
        }
    }
}
