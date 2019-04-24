using System;

namespace EbaObra.Domain.Entities.Base
{
	public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}