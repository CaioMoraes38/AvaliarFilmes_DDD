using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliarFilmes.Domain.Base
{    public abstract class BaseEntity<TID> : IBaseEntity
    {
        protected BaseEntity()
        {

        }

        protected BaseEntity(TID id)
        {
            Id = id;
        }

        public TID? Id { get; set; }
    }
}
