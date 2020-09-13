using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;

namespace Api.Data.Repository.GeometricForm
{
    public class GeometricFormRepository : BaseRepository<GeometricFormEntity>
    {
        protected new readonly MyContext _context;

        public GeometricFormRepository(MyContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<GeometricFormEntity> InsertAsyncGeometricForm(GeometricFormEntity item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();
                item.CreateAt = DateTime.UtcNow;
                _context.Set<GeometricFormEntity>().Add(item);
                await _context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return item;
        } 

        public async Task<GeometricFormEntity> UpdateAsyncGeometricForm(GeometricFormEntity item)
        {
            try
            {
                var result = await _context.Set<GeometricFormEntity>().FindAsync(item);
                if (result == null)
                    throw new Exception("Registro não encontrado!");
                item.UpdateAt = DateTime.UtcNow;
                //Isso garante que sempre fique a data de criação do registro
                item.CreateAt = result.CreateAt;
                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
    }
}

