using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.GeometricForm
{
    public interface IGeometricFormService
    {
        Task<GeometricFormEntity> Get(Guid id);
        Task<IEnumerable<GeometricFormEntity>> GetAll();
        Task<GeometricFormEntity> Post(GeometricFormEntity geometricForm);
        Task<GeometricFormEntity> Put(GeometricFormEntity geometricForm);
        Task<bool> Delete(Guid id);
        Task<bool> Exist(Guid id);
    }
}
