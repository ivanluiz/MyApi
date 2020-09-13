using Api.Data.Context;
using Api.Domain.Entities;

namespace Api.Data.Repository.GeometricForm
{
    public class DirectoryRepository : BaseRepository<DirectoryEntity>
    {
        public DirectoryRepository(MyContext context) : base(context)
        {
            
        }
    }
}

