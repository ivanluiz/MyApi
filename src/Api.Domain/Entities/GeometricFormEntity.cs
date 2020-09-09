using System;
using Api.Domain.Enums;

namespace Api.Domain.Entities
{
    public class GeometricFormEntity : BaseEntity
    {
        private DirectoryEntity _directoryEntity;
        public DirectoryEntity Directory
        {
            get { return this._directoryEntity; }
            set { this._directoryEntity = value; }
        }  
        public string Name { get; set; }
        public TypeGeometricForm Type { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
    }
}
